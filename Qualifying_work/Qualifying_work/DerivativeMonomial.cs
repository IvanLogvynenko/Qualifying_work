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
		public Monomial Monomial { get { return monomial; } }
		public double Power { get { return power; } }
		public double Multiplier { get { return multiplier; } }
		public DerivativeMonomial(Monomial monomial)
		{
			this.monomial = monomial;
			if (!this.monomial.IsEnd)
			{
				this.derivatePolynomial = new DerivatePolynomial(monomial.InnerPolynomial);
			}
			this.derivatesFunction = this.DerivatesFunction(this.monomial.Function);
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
		private DerivatesFunction DerivatesFunction(CountingFunction countingFunction)
		{
			switch (countingFunction.Description)
			{
				case "none":
					return new DerivatesFunction();
				case "sinus":
					return new DerivatesSinus();
				case "cosinus":
					return new DerivatesCosinus();
				case "tangens":
					return new DerivatesTangens();
				case "cotangens":
					return new DerivatesCotangens();
				case "arcsinus":
					return new DerivatesArcsinus();
				case "arccosinus":
					return new DerivatesArccosinus();
				case "arctangens":
					return new DerivatesArctangens();
				case "arccotangens":
					return new DerivatesArctangens();
				default:
					return new DerivatesFunction();
			}
		}
	}
}