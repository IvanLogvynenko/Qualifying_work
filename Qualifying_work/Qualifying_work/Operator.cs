using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Qualifying_work
{
	static class Operator
	{
		//basic params
		public static bool IsPanelOpened { get; set; }
		public static List<Polynomial> Polynomials { get; set; }
		//logical params(for background operating)
		public static bool LaunchingProgram { get; set; }
		public static bool Renew { get; set; }
		//chart params
		public static ChartArea ChartArea { get; set; }
		//enter params
		public static string BackSpace(string inputText)
		{
			char[] chars = inputText.ToCharArray();
			string newVariant = "";
			for (int i = 0; i < chars.Length - 1; i++)
			{
				newVariant += chars[i];
			}
			return newVariant;
		}
		public static int Breakets { get; set; }
		public static List<Series> SeriesRenew()
		{
			List<Series> Return = new List<Series>();
			Random Random = new Random();
			foreach (Polynomial polynomial in Operator.Polynomials)
			{
				Series series = new Series($"y={polynomial.PolynomialText}");
				for (double i = -5; i <= 5; i += 0.001)
				{
					series.Points.AddXY(i, polynomial.YCounter(i));
				}
				series.ChartType = SeriesChartType.Spline;
				series.Color = System.Drawing.Color.FromArgb(Random.Next(0, 255), Random.Next(0, 255), Random.Next(0, 255));
				series.BorderWidth = 3;
				Return.Add(series);
			}
			return Return;
		}
	}
}
