using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualifying_work
{
	public class DerivativeMonomial
	{
		readonly private double multiplier;
		readonly private double power;
		readonly private Monomial monomial;
		readonly private DerivatePolynomial derivatePolynomial;
		readonly private DerivatesFunction derivatesFunction;
		public DerivativeMonomial(Monomial monomial)
		{
			this.monomial = monomial;
			if (!this.monomial.IsEnd)
			{
				this.derivatePolynomial = new DerivatePolynomial(monomial.InnerPolynomial);
			}
			this.derivatesFunction = new DerivatesFunction();
			this.multiplier = monomial.Multiplier * monomial.Power;
			this.power = monomial.Power - 1;
			if (monomial.Function.Description == "segmentator")
			{
				this.power += 1;
				this.power *= -1;
				this.power -= 1;
			}
		}
		public double YCounter(double x)
		{
			if (this.monomial.IsEnd)
			{
				return this.multiplier * Math.Pow(this.derivatesFunction.Counter(x), this.power);
			}
			else
			{
				return this.multiplier * Math.Pow(this.derivatesFunction.Counter(this.derivatePolynomial.YCounter(x)), this.power);
			}
		}
	}
}