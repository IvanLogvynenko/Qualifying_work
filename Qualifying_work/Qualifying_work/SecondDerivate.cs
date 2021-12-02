using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualifying_work
{
	public class SecondDerivate
	{
		readonly private DerivatePolynomial derivatePolynomial;
		readonly private SecondDerivateMonomial[] secondDerivateMonomials;
		public SecondDerivate(DerivatePolynomial derivatePolynomial)
		{
			this.derivatePolynomial = derivatePolynomial;
			if (IsAbleToBeFinished(this.derivatePolynomial))
			{
				List<SecondDerivateMonomial> secondDerivateMonomials = new List<SecondDerivateMonomial>();
				foreach (DerivativeMonomial item in this.derivatePolynomial.DerivativeMonomials)
				{
					secondDerivateMonomials.Add(new SecondDerivateMonomial(item));
				}
				this.secondDerivateMonomials = secondDerivateMonomials.ToArray();
			}
		}
		public static bool IsAbleToBeFinished(DerivatePolynomial derivatePolynomial)
		{
			foreach (DerivativeMonomial item in derivatePolynomial.DerivativeMonomials)
			{
				if (!item.Monomial.IsEnd && !(item.Monomial.Function.Equals(new Cosinus())|| item.Monomial.Function.Equals(new CountingFunction()) || item.Monomial.Function.Equals(new Sinus())))
				{
					return false;
				}
			}
			return true;
		}
		public double YCounter(double x)
		{
			double answer = 0;
			foreach (SecondDerivateMonomial item in this.secondDerivateMonomials)
			{
				answer += item.YCounter(x);
			}
			return answer;
		}
	}
}