using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qualifying_work
{
	public partial class FuncChange : Form
	{
		public FuncChange()
		{
			InitializeComponent();
		}
		private static List<Button> Number_Buttons;
		private  static List<Button> Function_Buttons;
		private static List<Button> SpecialSymbols_Buttons;
		int Breakets = 0;
		private void FuncChange_Load(object sender, EventArgs e)
		{
			Number_Buttons = new List<Button>();
			Function_Buttons = new List<Button>();
			SpecialSymbols_Buttons = new List<Button>();
			Number_Buttons.Add(Btn0);
			Number_Buttons.Add(Btn1);
			Number_Buttons.Add(Btn2);
			Number_Buttons.Add(Btn3);
			Number_Buttons.Add(Btn4);
			Number_Buttons.Add(Btn5);
			Number_Buttons.Add(Btn6);
			Number_Buttons.Add(Btn7);
			Number_Buttons.Add(Btn8);
			Number_Buttons.Add(Btn9);
			SpecialSymbols_Buttons.Add(BtnCBracket);
			SpecialSymbols_Buttons.Add(BtnOBracket);
			SpecialSymbols_Buttons.Add(BtnMultiply);
			SpecialSymbols_Buttons.Add(BtnMinus);
			SpecialSymbols_Buttons.Add(BtnSegmentator);
			SpecialSymbols_Buttons.Add(BtnPlus);
			SpecialSymbols_Buttons.Add(BtnPower);
			Function_Buttons.Add(BtnSin);
			Function_Buttons.Add(BtnCos);
			Function_Buttons.Add(BtnTg);
			Function_Buttons.Add(BtnCtg);
			Function_Buttons.Add(BtnArcsin);
			Function_Buttons.Add(BtnArccos);
			Function_Buttons.Add(BtnArctg);
			Function_Buttons.Add(BtnArcctg);
			Number_Buttons.Add(BtnKoma);
			for (int i = 4; i < Operator.currentFunctions.ToString().Length; i++)
			{
				TBFunction.Text += Operator.currentFunctions.ToString()[i];
			}
		}
		private void FuncChange_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				Hide();
			}
		}
		private void BtnBackSpace_Click(object sender, EventArgs e)
		{
			TBFunction.Text = Operator.BackSpace(TBFunction.Text);
			//char Deleted = 'w';
			//if (TBFunction.Text.Length - 1>0)
			//{
			//	Deleted = TBFunction.Text[TBFunction.Text.Length - 1];
			//}
			Breakets = 0;
			foreach (char item in TBFunction.Text)
			{
				if (item == '(')
					Breakets++;
				if (item == ')')
					Breakets--;
			}
			//switch (Deleted)
			//{
			//	case '0':
			//		Btn0_Click(sender, e);
			//		break;
			//	case '1':
			//		Btn1_Click(sender, e);
			//		break;
			//	case '2':
			//		Btn2_Click(sender, e);
			//		break;
			//	case '3':
			//		Btn3_Click(sender, e);
			//		break;
			//	case '4':
			//		Btn4_Click(sender, e);
			//		break;
			//	case '5':
			//		Btn5_Click(sender, e);
			//		break;
			//	case '6':
			//		Btn6_Click(sender, e);
			//		break;
			//	case '7':
			//		Btn7_Click(sender, e);
			//		break;
			//	case '8':
			//		Btn8_Click(sender, e);
			//		break;
			//	case '9':
			//		Btn9_Click(sender, e);
			//		break;
			//	case 'w':
			//		Button_switcher();
			//		BtnX.Enabled = true;
			//		BtnPlus.Enabled = false;
			//		BtnPower.Enabled = false;
			//		BtnKoma.Enabled = false;
			//		BtnCBracket.Enabled = false;
			//		BtnMultiply.Enabled = false;
			//		BtnSegmentator.Enabled = false;
			//		break;
			//	default:
			//		break;
			//}
			//TBFunction.Text = Operator.BackSpace(TBFunction.Text);
		}
		private void BtnX_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "x";
			Button_switcher();
			Button_switcher(Number_Buttons, false);
			Button_switcher(Function_Buttons, false);
			BtnX.Enabled = false;
			BtnOBracket.Enabled = false;
			BtnSegmentator.Enabled = false;
		}
		#region Numbers
		private void Btn0_Click(object sender, EventArgs e)
		{
			TBFunction.Text += '0'.ToString();
			Button_switcher();
			BtnX.Enabled = true;
			Button_switcher(Function_Buttons, false);
			BtnMultiply.Enabled = false;
			BtnOBracket.Enabled = false;
		}
		private void BtnKoma_Click(object sender, EventArgs e)
		{
			TBFunction.Text += ",";
			Button_switcher();
			BtnX.Enabled = false;
			Button_switcher(Number_Buttons, true);
		}
		private void Btn1_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "1";
			Button_switcher();
			BtnX.Enabled = true;
			Button_switcher(Function_Buttons, false);
			Button_switcher(Number_Buttons, true);
			BtnOBracket.Enabled = false;
		}
		private void Btn2_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "2";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(Function_Buttons, false);
			Button_switcher(Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn3_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "3";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(Function_Buttons, false);
			Button_switcher(Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn4_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "4";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(Function_Buttons, false);
			Button_switcher(Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn5_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "5";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(Function_Buttons, false);
			Button_switcher(Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn6_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "6";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(Function_Buttons, false);
			Button_switcher(Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn7_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "7";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(Function_Buttons, false);
			Button_switcher(Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn8_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "8";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(Function_Buttons, false);
			Button_switcher(Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn9_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "9";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(Function_Buttons, false);
			Button_switcher(Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		#endregion
		#region Trigonometry
		private void BtnSin_Click(object sender, EventArgs e)
		{
			Breakets++;
			TBFunction.Text += "Sin(";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnCos_Click(object sender, EventArgs e)
		{
			Breakets++;
			TBFunction.Text += "Cos(";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnTg_Click(object sender, EventArgs e)
		{
			Breakets++;
			TBFunction.Text += "Tg(";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnCtg_Click(object sender, EventArgs e)
		{
			Breakets++;
			TBFunction.Text += "Ctg(";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnArcsin_Click(object sender, EventArgs e)
		{
			Breakets++;
			TBFunction.Text += "Arcsin(";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnArccos_Click(object sender, EventArgs e)
		{
			Breakets++;
			TBFunction.Text += "Arccos(";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnArctg_Click(object sender, EventArgs e)
		{
			Breakets++;
			TBFunction.Text += "Arctg(";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnArcctg_Click(object sender, EventArgs e)
		{
			Breakets++;
			TBFunction.Text += "Arcctg(";
			Button_switcher(); BtnX.Enabled = true;
			Button_switcher(SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		#endregion
		#region Symbols
		private void BtnPlus_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "+";
			Button_switcher();
			Button_switcher(SpecialSymbols_Buttons, false);
			BtnX.Enabled = true;
			BtnOBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnMinus_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "-";
			Button_switcher();
			Button_switcher(SpecialSymbols_Buttons, false);
			BtnX.Enabled = true;
			BtnOBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnOBracket_Click(object sender, EventArgs e)
		{
			Breakets++;
			TBFunction.Text += "(";
			Button_switcher();
			BtnX.Enabled = true;
			Button_switcher(SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnMinus.Enabled = true;
			BtnKoma.Enabled = true;
		}
		private void BtnCBracket_Click(object sender, EventArgs e)
		{
			Breakets--;
			TBFunction.Text += ")";
			Button_switcher(false);
			BtnCBracket.Enabled = Breakets != 0;
			BtnMinus.Enabled = true;
			BtnPlus.Enabled = true;
			BtnPower.Enabled = true;
		}
		private void BtnSegmentator_Click(object sender, EventArgs e)
		{
			Breakets++;
			TBFunction.Text += "/(";
			Button_switcher();
			BtnX.Enabled = true;
			Button_switcher(SpecialSymbols_Buttons, false);
			BtnMinus.Enabled = true;
			BtnKoma.Enabled = true;
		}
		private void BtnPower_Click(object sender, EventArgs e)
		{
			Breakets++;
			TBFunction.Text += "^(";
			Button_switcher();
			Button_switcher(SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnMinus.Enabled = true;
			BtnKoma.Enabled = true;
		}
		private void BtnMultiply_Click(object sender, EventArgs e)
		{
			Breakets++;
			TBFunction.Text += "*(";
			Button_switcher();
			BtnX.Enabled = true;
			Button_switcher(SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnMinus.Enabled = true;
			BtnKoma.Enabled = false;
		}
		#endregion
		private void BtnSave_Click(object sender, EventArgs e)
		{
			Operator.currentFunctions = new Function(new Polynomial(TBFunction.Text));
			Operator.Functions[Operator.currentChoise] = Operator.currentFunctions;
			Hide();
			Operator.koordinationSystem.Renew();
			FuncActions funcActions = new FuncActions();
			funcActions.Show();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Hide();
			FuncActions funcActions = new FuncActions();
			funcActions.Show();
		}
		#region Switchers
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
