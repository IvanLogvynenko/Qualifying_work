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
		readonly private Range Range;
		public string DomainFunction { get; }
		public string FunctionRange { get; }
		public string IsOdd { get; }
		public string IntersectionAxes { get; }
		public string HigherX { get; }
		public string LowerX { get; }
		public string Extrem { get; }
		public string Rising { get; }
		public string Falling { get; }
		public string InflectionPoints { get; }
		public string InflectionPlus { get; }
		public string InflectionMinus { get; }
		private char DiscoveryMode;
		public Analizer(Function Function, Range Range)
		{
			this.Function = Function;
			this.Range = Range;
			this.DiscoveryMode = 'f';
			this.IntersectionAxes = "Points of intersection with axes: " + Interpretator(Zeros()) + "\n";
			this.HigherX = "f(x)>0: " + Interpretator(Plus(Zeros())) + "\n";
			this.LowerX = "f(x)<0: " + Interpretator(Minus(Zeros())) + "\n";
			this.DiscoveryMode = 'd';
			this.Extrem = "Extremal points: " + Interpretator(Zeros()) + "\n";
			this.Rising = "f(x)↑: " + Interpretator(Plus(Zeros())) + "\n";
			this.Falling = "f(x)↓: " + Interpretator(Minus(Zeros())) + "\n";
			this.DiscoveryMode = 's';
			this.InflectionPoints = "Extremal points: " + Interpretator(Zeros()) + "\n";
			this.InflectionPlus = "Inflects inside: " + Interpretator(Plus(Zeros())) + "\n";
			this.InflectionMinus = "Inflects outside: " + Interpretator(Minus(Zeros())) + "\n";
			this.IsOdd = IisOdd() + "\n";
		}
		private string Interpretator(Range[] ranges)
		{
			string s;
			if (ranges.Length == 0)
			{
				s = "(-∞; +∞)";
			}
			else
			{
				s = "";
				foreach (Range item in ranges)
				{
					s += $"({Math.Round(item.Start)}; {Math.Round(item.End)})U";
				}
				s = Operator.BackSpace(s);
				s += ";";
			}
			s = s.Replace($"({this.Range.Start-1};", "(-∞;");
			s = s.Replace($"; {this.Range.End + 1})", "; +∞)");
			return s;
		}
		private string Interpretator(double[] zeros)
		{
			string s;
			s = "";
			foreach (double item in zeros)
			{
				s += $"{item}, ";
			}
			s = Operator.BackSpace(Operator.BackSpace(s));
			s += ";";
			return s;
		}
		private double Counter(double x)
		{
			double value = this.Range.Start - 1;
			x = Math.Round(x, 6);
			switch (this.DiscoveryMode)
			{
				case 'f':
					value = this.Function.YCounter(x);
					break;
				case 'd':
					value = this.Function.DerivateCounter(x);
					break;
				case 's':
					value = this.Function.SecondDerivateCounter(x);
					break;
				default:
					break;
			}
			return Math.Round(value, 6);
		}
		private double[] Zeros()
		{
			List<double> zeros = new List<double>();
			for (double i = this.Range.Start; i < this.Range.End; i += Operator.Step)
			{
				if (Counter(i) == 0)
				{
					zeros.Add(Math.Round(i, 6));
				}
			}
			return zeros.ToArray();
		}
		private Range[] Plus(double[] zeros)
		{
			List<Range> ranges = new List<Range>();
			int starter = 0;
			if (zeros.Length != 0)
			{
				if (Counter(zeros[0] + 0.005) < 0)
				{
					ranges.Add(new Range(this.Range.Start - 1, zeros[0]));
					starter++;
				}
				for (int i = starter; i < zeros.Length; i++)
				{
					double d = Counter(zeros[i] + 0.0005);
					if (d > 0)
					{
						if (i == zeros.Length - 1)
						{
							ranges.Add(new Range(zeros[i], this.Range.End + 1));
						}
						else
						{
							ranges.Add(new Range(zeros[i], zeros[i + 1]));
						}
					}
				}
			}
			return ranges.ToArray();
		}
		private Range[] Minus(double[] zeros)
		{
			List<Range> ranges = new List<Range>();
			int starter = 0;
			if (zeros.Length != 0)
			{
				if (Counter(zeros[0] + 0.005) > 0)
				{
					ranges.Add(new Range(this.Range.Start - 1, zeros[0]));
					starter++;
				}
				for (int i = starter; i < zeros.Length; i++)
				{
					double d = Counter(zeros[i] + 0.0005);
					if (d < 0)
					{
						if (i == zeros.Length - 1)
						{
							ranges.Add(new Range(zeros[i], this.Range.End + 1));
						}
						else
						{
							ranges.Add(new Range(zeros[i], zeros[i + 1]));
						}
					}
				}
			}
			return ranges.ToArray();
		}
		//private void DomainRange(ref string answer, ref string answerr)
		//{
		//	List<Range> Points = new List<Range>();
		//	double memory = Double.NaN;
		//	bool changer = false;
		//	for (double i = this.Range.Start; i < this.Range.End; i += Operator.koordinationSystem.Area.Step)
		//	{
		//		if (Exists(i))
		//		{
		//			if (!changer)
		//			{
		//				changer = false;
		//				memory = i;
		//			}
		//		}
		//		else
		//		{
		//			if (changer)
		//			{
		//				changer = true;
		//				Points.Add(new Range(Math.Round(memory), Math.Round(i)));
		//			}
		//		}
		//	}
		//	answer = "D(f): ";
		//	for (int i = 0; i < Points.Count; i++)
		//	{
		//		if (i == Points.Count - 1)
		//		{
		//			answer += $"({Points[i].Start}; {Points[i].End})";
		//		}
		//		else
		//		{
		//			answer += $"({Points[i].Start}; {Points[i].End})U";
		//		}
		//	}
		//	answerr = "E(f): ";
		//	for (int i = 0; i < Points.Count; i++)
		//	{
		//		if (i == Points.Count - 1)
		//		{
		//			answer += $"({this.Function.YCounter(Points[i].Start)}; {this.Function.YCounter(Points[i].End)})";
		//		}
		//		else
		//		{
		//			answer += $"({this.Function.YCounter(Points[i].Start)}; {this.Function.YCounter(Points[i].End)})U";
		//		}
		//	}
		//	if (Points.Count == 0)
		//	{
		//		answer += "(-∞; +∞)";
		//		answerr += "(-∞; +∞)";
		//	}
		//}
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