using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Qualifying_work
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			Operator.IsPanelOpened = false;
			Operator.Polynomials = new List<Polynomial>();
			Operator.Number_Buttons = new List<Button>();
			Operator.Function_Buttons = new List<Button>();
			Operator.SpecialSymbols_Buttons = new List<Button>();
			Operator.LaunchingProgram = true;
			Operator.Renew = true;
			Operator.ChartArea = new ChartArea();
			Operator.Breakets = 0;
			Timer1.Interval = 10;
			Timer1.Start();
		}
		private void BtnEnter_Click(object sender, EventArgs e)
		{
			try
			{
				Polynomial polynomial = new Polynomial(TBFunction.Text);
				Operator.Polynomials.Add(polynomial);
				Chart1.Series.Clear();
				foreach (Series serie in Operator.SeriesRenew())
				{
					Chart1.Series.Add(serie);
				}
			}
			catch (StackOverflowException) { }
			TBFunction.Text = "";
		}
		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (Operator.LaunchingProgram)
			{
				Chart1.Series.Clear();
				Operator.ChartArea.AxisX.Minimum = -5;
				Operator.ChartArea.AxisX.Maximum = 5;
				Operator.ChartArea.AxisX.Interval = 1;
				Operator.ChartArea.AxisX.ArrowStyle = AxisArrowStyle.SharpTriangle;
				Operator.ChartArea.AxisX.Crossing = 0;
				Operator.ChartArea.AxisX.LabelStyle.IsEndLabelVisible = false;
				Operator.ChartArea.AxisY.Minimum = -5;
				Operator.ChartArea.AxisY.Maximum = 5;
				Operator.ChartArea.AxisY.Interval = 1;
				Operator.ChartArea.AxisY.ArrowStyle = AxisArrowStyle.SharpTriangle;
				Operator.ChartArea.AxisY.Crossing = 0;
				Operator.ChartArea.AxisY.LabelStyle.IsEndLabelVisible = false;
				Operator.Number_Buttons.Add(Btn0);
				Operator.Number_Buttons.Add(Btn1);
				Operator.Number_Buttons.Add(Btn2);
				Operator.Number_Buttons.Add(Btn3);
				Operator.Number_Buttons.Add(Btn4);
				Operator.Number_Buttons.Add(Btn5);
				Operator.Number_Buttons.Add(Btn6);
				Operator.Number_Buttons.Add(Btn7);
				Operator.Number_Buttons.Add(Btn8);
				Operator.Number_Buttons.Add(Btn9);
				Operator.SpecialSymbols_Buttons.Add(BtnCBracket);
				Operator.SpecialSymbols_Buttons.Add(BtnOBracket);
				Operator.SpecialSymbols_Buttons.Add(BtnMultiply);
				Operator.SpecialSymbols_Buttons.Add(BtnMinus);
				Operator.SpecialSymbols_Buttons.Add(BtnSegmentator);
				Operator.SpecialSymbols_Buttons.Add(BtnPlus);
				Operator.SpecialSymbols_Buttons.Add(BtnPower);
				Operator.Function_Buttons.Add(BtnSin);
				Operator.Function_Buttons.Add(BtnCos);
				Operator.Function_Buttons.Add(BtnTg);
				Operator.Function_Buttons.Add(BtnCtg);
				Operator.Function_Buttons.Add(BtnArcsin);
				Operator.Function_Buttons.Add(BtnArccos);
				Operator.Function_Buttons.Add(BtnArctg);
				Operator.Function_Buttons.Add(BtnArcctg);
				Operator.Number_Buttons.Add(BtnKoma);
				Operator.LaunchingProgram = false;
			}
			if (Operator.Renew)
			{
				Chart1.ChartAreas[0] = Operator.ChartArea;
				Operator.Renew = false;
			}
		}
		private void TBFunction_TextChanged(object sender, EventArgs e)
		{
			BtnEnter.Enabled = (Operator.Breakets == 0) && (TBFunction.Text != "");
			BtnBackSpace.Enabled = TBFunction.Text != "";
		}
		#region All buttons
		private void BtnBackSpace_Click(object sender, EventArgs e)
		{
			char Deleted = TBFunction.Text[TBFunction.Text.Length - 1];
			TBFunction.Text = Operator.BackSpace(TBFunction.Text);
			Operator.Breakets = 0;
			foreach (char item in TBFunction.Text)
			{
				if (item == '(')
					Operator.Breakets++;
				if (item == ')')
					Operator.Breakets--;
			}
			switch (Deleted)
			{
				case ')':
					break;
				default:
					break;
			}
		}
		private void ShowingBtn_Click(object sender, EventArgs e)
		{
			if (Operator.IsPanelOpened)
			{
				Operator.IsPanelOpened = false;
				for (int i = 0; i < 22; i++)
				{
					pnlProVersion.Location = new Point(pnlProVersion.Location.X, pnlProVersion.Location.Y + 10);
				}
			}
			else
			{
				Operator.IsPanelOpened = true;
				for (int i = 0; i < 22; i++)
				{
					pnlProVersion.Location = new Point(pnlProVersion.Location.X, pnlProVersion.Location.Y - 10);
				}
			}
		}
		
		private void BtnX_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "x";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.Number_Buttons, false);
			Operator.Button_switcher(Operator.Function_Buttons, false);
			BtnX.Enabled = false;
			BtnOBracket.Enabled = false;
			BtnCBracket.Enabled = false;
			BtnSegmentator.Enabled = false;
		}
		#region Numbers
		private void Btn0_Click(object sender, EventArgs e)
		{
			TBFunction.Text += '0'.ToString();
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.Function_Buttons, false);
			BtnMultiply.Enabled = false;
			BtnOBracket.Enabled = false;
			BtnCBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void BtnKoma_Click(object sender, EventArgs e)
		{
			TBFunction.Text += ",";
			Operator.Button_switcher(false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
		}
		private void Btn1_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "1";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnCBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn2_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "2";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnCBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn3_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "3";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnCBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn4_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "4";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnCBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn5_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "5";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnCBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn6_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "6";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnCBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn7_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "7";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnCBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn8_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "8";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnCBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn9_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "9";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnCBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		#endregion
		#region Trigonometry
		private void BtnSin_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Sin(";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnCos_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Cos(";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnTg_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Tg(";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnCtg_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Ctg(";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnArcsin_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Arcsin(";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnArccos_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Arccos(";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnArctg_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Arctg(";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnArcctg_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Arcctg(";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		//private void BtnLog_Click(object sender, EventArgs e)
		//{
		//	Operator.Breakets++;
		//	TBFunction.Text += "Log(";
		//}
		#endregion
		#region Symbols
		private void BtnPlus_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "+";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnCBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void BtnMinus_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "-";
			Operator.Button_switcher();
			Btn0.Enabled = true;
		}
		private void BtnOBracket_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "(";
		}
		private void BtnCBracket_Click(object sender, EventArgs e)
		{
			Operator.Breakets--;
			TBFunction.Text += ")";
		}
		private void BtnSegmentator_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "/(";

		}
		private void BtnPower_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "^(";
		}
		private void BtnMultiply_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "*(";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		#endregion

		#endregion
	}
}