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
		public string InflctionPoints { get; }
		public Analizer(Function Function, Range Range)
		{
			this.Function = Function;
			this.Range = Range;
		}
		private string DomainRange()
		{
			List<Point> points = new List<Point>();
			List<double> noPoints = new List<double>();
			bool changer = true;
			for (double i = this.Range.Start; i < this.Range.End; i+=Operator.koordinationSystem.Area.Step)
			{
				try
				{
					points.Add(new Point(Operator.koordinationSystem.Xtoi(i), Operator.koordinationSystem.Ytoj(this.Function.YCounter(i))));

				}
				catch (OverflowException)
				{
					noPoints.Add(i);
				}
			}
		}
		private string IsOdd()
		{
			bool isOdd = true;
			bool isEven = true;
			for (double i = this.Range.Start; i < 0; i+=Operator.Step)
			{
				if (this.Function.YCounter(i) != -1*this.Function.YCounter(-1*i))
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