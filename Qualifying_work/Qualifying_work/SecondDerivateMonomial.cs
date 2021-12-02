using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualifying_work
{
	public class SecondDerivateMonomial
	{
		readonly private DerivativeMonomial derivativeMonomial;
		readonly private double power;
		readonly private double multiplier;
		readonly private SecondDerivateFunction function;
		public DerivativeMonomial DerivativeMonomial { get { return derivativeMonomial; } }
		public SecondDerivateMonomial(DerivativeMonomial derivativeMonomial)
		{
			this.derivativeMonomial = derivativeMonomial;
			this.multiplier = this.derivativeMonomial.Multiplier * this.derivativeMonomial.Power;
			this.power = this.derivativeMonomial.Power - 1;
			this.function = this.SecondDerivateFunction(this.derivativeMonomial);
		}
		public SecondDerivateFunction SecondDerivateFunction(DerivativeMonomial derivativeMonomial)
		{
			switch (derivativeMonomial.Monomial.Function.Description)
			{
				case "none":
					return new SecondDerivateFunction();
				case "sinus":
					return new SecondDerivateSinus();
				case "cosinus":
					return new SecondDerivateCosinus();
				default:
					return new SecondDerivateFunction();
			}
		}
		public double YCounter(double x)
		{
			return this.multiplier * Math.Pow(this.function.Counter(x), this.power);
		}
	}
	public class SecondDerivateFunction 
	{
		public virtual double Counter(double x)
		{
			try { return x; } catch (OverflowException) { throw; }
		}
	}
	public class SecondDerivateSinus : SecondDerivateFunction
	{
		public override double Counter(double x)
		{
			return Math.Cos(base.Counter(x));
		}
	}
	public class SecondDerivateCosinus : SecondDerivateFunction
	{
		public override double Counter(double x)
		{
			return -1 * Math.Sin(base.Counter(x));
		}
	}
}