using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Qualifying_work
{
	public class Function
	{
		readonly private Polynomial polynomial;
		readonly private DerivatePolynomial derivatePolynomial;
		readonly private SecondDerivate secondDerivate;
		public Point[] Points;
		public Color Color { get; set; }
		public double DerivateCounter(double x)
		{
			return this.derivatePolynomial.YCounter(x);
		}
		public double YCounter(double x)
		{
			return this.polynomial.YCounter(x);
		}
		public Function(Polynomial polynomial)
		{
			this.polynomial = polynomial;
			this.derivatePolynomial = new DerivatePolynomial(this.polynomial);
			if (SecondDerivate.IsAbleToBeFinished(this.derivatePolynomial))
			{
				this.secondDerivate = new SecondDerivate(this.derivatePolynomial);
			}
			List<Point> points = new List<Point>();
			for (double x = Operator.koordinationSystem.Area.XMin; x < Operator.koordinationSystem.Area.XMax; x += Operator.Step)
			{
				try
				{
					points.Add(new Point(Operator.koordinationSystem.Xtoi(x), Operator.koordinationSystem.Ytoj(this.polynomial.YCounter(x))));
				}
				catch (OverflowException) { }
			}
			this.Points = points.ToArray();
			Random random = new Random();
			this.Color = Operator.RandomColor();
		}
		public override string ToString()
		{
			return $"y = {this.polynomial.PolynomialText}";
		}
		public double SecondDerivateCounter(double x)
        {
			return this.secondDerivate.YCounter(x);
        }
	}
}