using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualifying_work
{
	public class Analizer
	{
		public Function Function { get; }
		private Range Range;
		public string DomainFunction { get; }
		public string FunctionRange { get; }
		public string IsOdd { get; }
		public string IntersectionAxes { get; }
		public string InflectionPoints { get; }
		public string Rising { get; }
		public string Falling { get; }
		public Analizer(Function Function, Range Range)
		{
			this.Function = Function;
			this.Range = Range;
			string s = "", s1 = "", s2 = "", s3 = "", s4 = "";
			DomainRange(ref s, ref s1);
			Zeros(ref s2);
			this.DomainFunction = s;
			this.FunctionRange = s1;
			this.IntersectionAxes = s2;
			this.IsOdd = IisOdd();
			RisingFalling(ref s3, ref s4);
			this.Rising = s3;
			this.Falling = s4;
		}
		private void RisingFalling(ref string rising, ref string falling)
		{
			List<Range> Rising = new List<Range>();
			List<Range> Falling = new List<Range>();
			PlusMinus(ref Rising, ref Falling, StartswithMinus());
			rising = "rising on interval";
			falling = "falling on interval";
			foreach (Range item in Rising)
			{
				rising += $"({item.Start}, {item.End})U";
			}
			char[] c = rising.ToCharArray();
			rising = "";
			c[c.Length - 1] = ';';
			foreach (char item in c)
			{
				rising += item.ToString();
			}
			foreach (Range item in Falling)
			{
				falling += $"({item.Start}, {item.End})U";
			}
			char[] cm = rising.ToCharArray();
			falling = "";
			cm[cm.Length - 1] = ';';
			foreach (char item in cm)
			{
				falling += item.ToString();
			}
		}
		private bool StartswithMinus()
		{
			bool IsMin = true, start = true;
			for (int i = 0; start; i++)
			{
				if (this.Function.DerivateCounter(this.Range.Start) != 0)
				{
					if (this.Function.DerivateCounter(this.Range.Start) > 0)
					{
						IsMin = false;
					}
					else
					{
						IsMin = true;
					}
					start = false;
				}
			}
			return IsMin;
		}
		private void PlusMinus(ref List<Range> Plus, ref List<Range> Minus, bool minus)
		{
			double memory = -5;
			for (double i = this.Range.Start + Operator.koordinationSystem.Area.Step; i < this.Range.End; i += Operator.koordinationSystem.Area.Step)
			{
				if (this.Function.DerivateCounter(i) > 0)
				{
					if (minus)
					{
						minus = false;
						Minus.Add(new Range(memory, i));
						memory = i;
					}
				}
				else
				{
					if (!minus)
					{
						minus = true;
						Plus.Add(new Range(memory, i));
						memory = i;
					}
				}
			}
		}
		private void DomainRange(ref string answer, ref string answerr)
		{
			List<Range> Points = new List<Range>();
			double memory = Double.NaN;
			bool changer = false;
			for (double i = this.Range.Start; i < this.Range.End; i += Operator.koordinationSystem.Area.Step)
			{
				if (Exists(i))
				{
					if (!changer)
					{
						changer = false;
						memory = i;
					}
				}
				else
				{
					if (changer)
					{
						changer = true;
						Points.Add(new Range(Math.Round(memory), Math.Round(i)));
					}
				}
			}
			answer = "D(f): ";
			for (int i = 0; i < Points.Count; i++)
			{
				if (i == Points.Count - 1)
				{
					answer += $"({Points[i].Start}; {Points[i].End})";
				}
				else
				{
					answer += $"({Points[i].Start}; {Points[i].End})U";
				}
			}
			answerr = "E(f): ";
			for (int i = 0; i < Points.Count; i++)
			{
				if (i == Points.Count - 1)
				{
					answer += $"({this.Function.YCounter(Points[i].Start)}; {this.Function.YCounter(Points[i].End)})";
				}
				else
				{
					answer += $"({this.Function.YCounter(Points[i].Start)}; {this.Function.YCounter(Points[i].End)})U";
				}
			}
			if (Points.Count == 0)
			{
				answer += "(-∞; +∞)";
				answerr += "(-∞; +∞)";
			}
		}
		private bool Exists(double x)
		{
			try
			{
				this.Function.YCounter(x);
				return true;
			}
			catch (OverflowException)
			{
				return false;
			}
		}
		private string IisOdd()
		{
			bool isOdd = true;
			bool isEven = true;
			for (double i = this.Range.Start; i < 0; i += Operator.Step)
			{
				if (this.Function.YCounter(i) != -1 * this.Function.YCounter(-1 * i))
				{
					isOdd = false;
					break;
				}
			}
			if (isOdd)
			{
				return "Is odd";
			}
			else
			{
				for (double i = this.Range.Start; i < 0; i += Operator.Step)
				{
					if (this.Function.YCounter(i) != this.Function.YCounter(-1 * i))
					{
						isEven = false;
						break;
					}
				}
				if (isEven)
				{
					return "Is Even";
				}
				else
				{
					return "Is Indifferent";
				}
			}
		}
		private void Zeros(ref string zero)
		{
			zero = "function zeros: ";
			for (double i = this.Range.Start; i < this.Range.End; i += Operator.koordinationSystem.Area.Step)
			{
				if (Math.Round(this.Function.YCounter(i), 2) == 0)
				{
					zero += $"({i}, {Math.Round(this.Function.YCounter(i), 2)})";
				}
			}
			zero += $"(0, {Math.Round(this.Function.YCounter(0), 2)})";
		}
	}
	public class Range
	{
		public double Start { get; }
		public double End { get; }
		public Range(double Start, double End)
		{
			this.Start = Start;
			this.End = End;
		}
	}
}