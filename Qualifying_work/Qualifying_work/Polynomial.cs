using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualifying_work
{
	public class Polynomial
	{
		Monomial[] Monomials { get; }
		public string PolynomialText { get; }
		public Polynomial(string input)
		{
			input = input.Replace(" ", "");
			input = input.Replace(".", ",");
			this.PolynomialText = input;
			this.Monomials = this.Separator(input);
		}
		public double YCounter(double x)
		{
			double answer = 0;
			foreach (Monomial item in this.Monomials)
			{
				answer += item.YCounter(x);
			}
			return answer;
		}
		private Monomial[] Separator(string input)
		{
			List<Monomial> sep = new List<Monomial>();
			string temp = "";
			int brackets = 0;
			foreach (char item in input)
			{
				if (item == '(')
				{
					brackets++;
				}
				if (item == ')')
				{
					brackets--;
				}
				if ((item == '+' || item == '-') && brackets == 0)
				{
					sep.Add(new Monomial(temp));
					if (item == '+')
					{
						temp = "";
					}
					else
					{
						temp = "-";
					}
				}
				else
				{
					temp += item;
				}
			}
			sep.Add(new Monomial(temp));
			return sep.ToArray();
		}
	}
}