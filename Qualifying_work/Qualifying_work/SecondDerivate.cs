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
				if (!item.Monomial.IsEnd)
				{
					return false;
				}
			}
			return true;
		}
	}
}