using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace Qualifying_work
{
	static class Operator
	{
		public static List<Polynomial> Polynomials;
		public static int Breakets;
		#region button lists
		public static List<Button> Number_Buttons;
		public static List<Button> Function_Buttons;
		public static List<Button> SpecialSymbols_Buttons;
		#endregion
		#region logical params(for background operating)
		public static bool LaunchingProgram;
		public static bool Renew;
		public static bool IsPanelOpened;
		#endregion
		#region chart params
		public static ChartArea ChartArea;
		#endregion
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
		public static void Button_switcher(List<Button> buttons)
		{
			foreach (Button item in buttons)
			{
				item.Enabled = Convert.ToBoolean(true);
			}
		}
		public static void Button_switcher(List<Button> buttons, bool value)
		{
			foreach (Button item in buttons)
			{
				item.Enabled = value;
			}
		}
		public static void Button_switcher(bool value)
		{
			foreach (Button item in Function_Buttons)
			{
				item.Enabled = value;
			}
			foreach (Button item in Number_Buttons)
			{
				item.Enabled = value;
			}
			foreach (Button item in SpecialSymbols_Buttons)
			{
				item.Enabled = value;
			}
			
		}
		public static void Button_switcher()
		{
			foreach (Button item in Function_Buttons)
			{
				item.Enabled = true;
			}
			foreach (Button item in Number_Buttons)
			{
				item.Enabled = true;
			}
			foreach (Button item in SpecialSymbols_Buttons)
			{
				item.Enabled = true;
			}
		}
	}
}
