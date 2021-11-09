using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualifying_work
{
	class CountingFunction
	{
		public virtual double Counter(double x)
		{
			try { return x; }
			catch (OverflowException) { throw; }
		}
	}
	class Sinus : CountingFunction
	{
		public override double Counter(double x) { return Math.Sin(base.Counter(x)); }
	}
	class Cosinus : CountingFunction
	{
		public override double Counter(double x) { return Math.Cos(base.Counter(x)); }
	}
	class Tangens : CountingFunction
	{
		public override double Counter(double x) { return Math.Tan(base.Counter(x)); }
	}
	class Cotangens : CountingFunction
	{
		public override double Counter(double x) { return 1 / Math.Tan(base.Counter(x)); }
	}
	class Arcsinus : CountingFunction
	{
		public override double Counter(double x) { return Math.Asin(base.Counter(x)); }
	}
	class Arccosinus : CountingFunction
	{
		public override double Counter(double x) { return Math.Acos(base.Counter(x)); }
	}
	class Arctangens : CountingFunction
	{
		public override double Counter(double x) { return Math.Atan(base.Counter(x)); }
	}
	class Arccotangens : CountingFunction
	{
		public override double Counter(double x) { return Math.PI / 2 - Math.Atan(base.Counter(x)); }
	}
	class Logarithm : CountingFunction
	{
		double lbase = 0;
		public Logarithm(double lbase)
		{
			this.lbase = lbase;
		}
		public override double Counter(double x) { return Math.Log(base.Counter(x), lbase); }
	}
	class Segmentator : CountingFunction
	{
		public override double Counter(double x) { return 1 / base.Counter(x); }
	}
}