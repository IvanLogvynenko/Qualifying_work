using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualifying_work
{
	public class DerivatePolynomial
	{
		readonly private Polynomial polynomial;
		readonly private DerivativeMonomial[] derivativeMonomials;
		public DerivatePolynomial(Polynomial polynomial)
		{
			this.polynomial = polynomial;
			List<DerivativeMonomial> derivativeMonomials = new List<DerivativeMonomial>();
			foreach (Monomial item in this.polynomial.Monomials)
			{
				derivativeMonomials.Add(new DerivativeMonomial(item));
			}
			this.derivativeMonomials = derivativeMonomials.ToArray();
		}
		public double YCounter(double x)
		{
			double Sum = 0;
			foreach (DerivativeMonomial item in this.derivativeMonomials)
			{
				Sum += item.YCounter(x);
			}
			return Sum;
		}
	}
}
