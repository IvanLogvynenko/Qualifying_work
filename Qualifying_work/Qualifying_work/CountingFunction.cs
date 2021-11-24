using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualifying_work
{
	public class CountingFunction
	{
		public string Description;
		public CountingFunction()
        {
			Description = "none";
        }
		public virtual double Counter(double x)
		{
			try { return x; }
			catch (OverflowException) { throw; }
		}
	}
	public class Sinus : CountingFunction
	{
		public Sinus()
        {
			base.Description = "sinus";
        }
		public override double Counter(double x) { return Math.Sin(base.Counter(x)); }
	}
	public class Cosinus : CountingFunction
	{
		public Cosinus()
        {
			base.Description = "cosinus";
        }
		public override double Counter(double x) { return Math.Cos(base.Counter(x)); }
	}
	public class Tangens : CountingFunction
	{
		public Tangens()
        {
			base.Description = "tangens";
        }
		public override double Counter(double x) { return Math.Tan(base.Counter(x)); }
	}
	public class Cotangens : CountingFunction
	{
		public Cotangens()
        {
			base.Description = "cotangens";
        }
		public override double Counter(double x) { return 1 / Math.Tan(base.Counter(x)); }
	}
	public class Arcsinus : CountingFunction
	{
		public Arcsinus()
        {
			base.Description = "arcsinus";
        }
		public override double Counter(double x) { return Math.Asin(base.Counter(x)); }
	}
	public class Arccosinus : CountingFunction
	{
		public Arccosinus()
        {
			base.Description = "arccosinus";
        }
		public override double Counter(double x) { return Math.Acos(base.Counter(x)); }
	}
	public class Arctangens : CountingFunction
	{
		public Arctangens()
        {
			base.Description = "arctangens";
        }
		public override double Counter(double x) { return Math.Atan(base.Counter(x)); }
	}
	public class Arccotangens : CountingFunction
	{
		public Arccotangens()
        {
			base.Description = "arccotangens";
        }
		public override double Counter(double x) { return Math.PI / 2 - Math.Atan(base.Counter(x)); }
	}
	public class Segmentator : CountingFunction
	{
		readonly private double Multiplier;
		public Segmentator(double Multiplier)
		{
			this.Multiplier = Multiplier;
			base.Description = "segmentator";
		}
		public override double Counter(double x)
		{
			if (x != 0)
			{
				return this.Multiplier / base.Counter(x);
			}
			else
			{
				return this.Multiplier / base.Counter(x + 0.001);
			}
		}
	}
}