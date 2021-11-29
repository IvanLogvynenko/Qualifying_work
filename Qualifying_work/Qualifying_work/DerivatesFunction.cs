using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualifying_work
{
	public class DerivatesFunction
	{
		public virtual double Counter(double x)
		{
			try { return x; } catch (OverflowException) { throw; }
		}
	}
	public class DerivatesSinus : DerivatesFunction
	{
		public override double Counter(double x)
		{
			return Math.Cos(base.Counter(x));
		}
	}
	public class DerivatesCosinus : DerivatesFunction
	{
		public override double Counter(double x)
		{
			return -1 * Math.Sin(base.Counter(x));
		}
	}
	public class DerivatesTangens : DerivatesFunction
	{
		public override double Counter(double x)
		{
			try
			{
				return 1 / Math.Pow(Math.Sin(base.Counter(x)), 2);
			}
			catch (OverflowException)
			{

				return 1 / Math.Pow(Math.Sin(base.Counter(x + 0.001)), 2);
			}
		}
	}
	public class DerivatesCotangens : DerivatesFunction
	{
		public override double Counter(double x)
		{
			try
			{
				return -1 / Math.Pow(Math.Cos(base.Counter(x)), 2);
			}
			catch (OverflowException)
			{

				return -1 / Math.Pow(Math.Cos(base.Counter(x + 0.001)), 2);
			}
		}
	}
	public class DerivatesArcsinus : DerivatesFunction
	{
		public override double Counter(double x)
		{
			try
			{
				return 1 / Math.Sqrt(1-Math.Pow(base.Counter(x),2));
			}
			catch (OverflowException)
			{

				return 1 / Math.Sqrt(1 - Math.Pow(base.Counter(x+0.001), 2));
			}
		}
	}
	public class DerivatesArccosinus : DerivatesFunction
	{
		public override double Counter(double x)
		{
			try
			{
				return -1 / Math.Sqrt(1 - Math.Pow(base.Counter(x), 2));
			}
			catch (OverflowException)
			{

				return -1 / Math.Sqrt(1 - Math.Pow(base.Counter(x + 0.001), 2));
			}
		}
	}
	public class DerivatesArctangens : DerivatesFunction
	{
		public override double Counter(double x)
		{
			try
			{
				return 1 / Math.Sqrt(1 + Math.Pow(base.Counter(x), 2));
			}
			catch (OverflowException)
			{

				return 1 / Math.Sqrt(1 + Math.Pow(base.Counter(x + 0.001), 2));
			}
		}
	}
	public class DerivatesArccotengens : DerivatesFunction
	{
		public override double Counter(double x)
		{
			try
			{
				return -1 / Math.Sqrt(1 + Math.Pow(base.Counter(x), 2));
			}
			catch (OverflowException)
			{

				return -1 / Math.Sqrt(1 + Math.Pow(base.Counter(x + 0.001), 2));
			}
		}
	}
}