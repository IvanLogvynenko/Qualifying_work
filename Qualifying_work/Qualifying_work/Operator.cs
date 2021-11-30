using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;

namespace Qualifying_work
{
	//static class Operator
	{
		public static List<Function> Functions;
		public static Function currentFunctions;
		public static int currentChoise;
		public static int Breakets;
		public static KoordinationSystem koordinationSystem;
		public static Bitmap Bitmap;
		public static double Step;
		#region button lists
		public static List<Button> Number_Buttons;
		public static List<Button> Function_Buttons;
		public static List<Button> SpecialSymbols_Buttons;
		#endregion
		#region logical params(for background operating)
		public static bool LaunchingProgram, Renew, IsPanelOpened;
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
		public static bool IsInteger(double number)
		{
			return number % 1 == 0;
		}
		#region ButtonSwitcher
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
		#endregion
	}
}
