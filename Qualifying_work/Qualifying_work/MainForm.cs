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
			Operator.Functions = new List<Function>();
			Operator.Number_Buttons = new List<Button>();
			Operator.Function_Buttons = new List<Button>();
			Operator.SpecialSymbols_Buttons = new List<Button>();
			Operator.Bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			Operator.koordinationSystem = new KoordinationSystem(new Area(-5, 5, -5, 5, 1), new Area(0, pictureBox1.Width, 0, pictureBox1.Width));
			Operator.LaunchingProgram = true;
			Operator.Renew = true;
			Operator.Breakets = 0;
			Operator.Step = 0.001;
			Timer1.Interval = 10;
			Timer1.Start();
			listBox1.Items.Clear();
			pictureBox1.MouseWheel += PictureBox1_MouseWheel;
		}
		private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
		{
			Operator.koordinationSystem.Area.XMin += 0.2 * e.Delta / 120;
			Operator.koordinationSystem.Area.XMax -= 0.2 * e.Delta / 120;
			Operator.koordinationSystem.Area.YMin += 0.2 * e.Delta / 120;
			Operator.koordinationSystem.Area.YMax -= 0.2 * e.Delta / 120;
			Operator.koordinationSystem.Renew();
		}
		private void BtnEnter_Click(object sender, EventArgs e)
		{
			ShowingBtn_Click(sender, e);
			try
			{
				Function function = new Function(new Polynomial(TBFunction.Text));
				Operator.Functions.Add(function);
				Operator.koordinationSystem.BuildFuncton(function);
				listBox1.Items.Add(function.ToString());
			}
			catch (StackOverflowException) { }
			TBFunction.Text = "";
			Operator.Renew = true;
			Operator.Button_switcher();
			BtnX.Enabled = true;
			BtnPlus.Enabled = false;
			BtnPower.Enabled = false;
			BtnKoma.Enabled = false;
			BtnCBracket.Enabled = false;
			BtnMultiply.Enabled = false;
			BtnSegmentator.Enabled = false;
		}
		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (Operator.LaunchingProgram)
			{
				Operator.koordinationSystem.BuildSystem(true);
				#region fillButtons
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
				#endregion
				Operator.LaunchingProgram = false;
			}
			if (Operator.Renew)
			{
				pictureBox1.Image = Operator.Bitmap;
				listBox1.Items.Clear();
				foreach (Function item in Operator.Functions)
				{
					listBox1.Items.Add(item.ToString());
				}
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
			TBFunction.Text = Operator.BackSpace(TBFunction.Text);
			//char Deleted = 'w';
			//if (TBFunction.Text.Length - 1>0)
			//{
			//	Deleted = TBFunction.Text[TBFunction.Text.Length - 1];
			//}
			Operator.Breakets = 0;
			foreach (char item in TBFunction.Text)
			{
				if (item == '(')
					Operator.Breakets++;
				if (item == ')')
					Operator.Breakets--;
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
			//		Operator.Button_switcher();
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
		private void ShowingBtn_Click(object sender, EventArgs e)
		{
			if (Operator.IsPanelOpened)
			{
				Operator.IsPanelOpened = false;
				for (int i = 0; i < 20; i++)
				{
					pnlProVersion.Location = new Point(pnlProVersion.Location.X, pnlProVersion.Location.Y + 10);
				}
			}
			else
			{
				Operator.IsPanelOpened = true;
				for (int i = 0; i < 20; i++)
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
			BtnSegmentator.Enabled = false;
		}
		#region Numbers
		private void Btn0_Click(object sender, EventArgs e)
		{
			TBFunction.Text += '0'.ToString();
			Operator.Button_switcher(); 
			BtnX.Enabled = true;
			Operator.Button_switcher(Operator.Function_Buttons, false);
			BtnMultiply.Enabled = false;
			BtnOBracket.Enabled = false;
		}
		private void BtnKoma_Click(object sender, EventArgs e)
		{
			TBFunction.Text += ",";
			Operator.Button_switcher(); 
			BtnX.Enabled = false;
			Operator.Button_switcher(Operator.Number_Buttons, true);
		}
		private void Btn1_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "1";
			Operator.Button_switcher(); 
			BtnX.Enabled = true;
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
		}
		private void Btn2_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "2";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn3_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "3";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn4_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "4";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn5_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "5";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn6_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "6";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn7_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "7";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn8_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "8";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		private void Btn9_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "9";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.Function_Buttons, false);
			Operator.Button_switcher(Operator.Number_Buttons, true);
			BtnOBracket.Enabled = false;
			BtnX.Enabled = false;
		}
		#endregion
		#region Trigonometry
		private void BtnSin_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Sin(";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnCos_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Cos(";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnTg_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Tg(";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnCtg_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Ctg(";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnArcsin_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Arcsin(";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnArccos_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Arccos(";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnArctg_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Arctg(";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnArcctg_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "Arcctg(";
			Operator.Button_switcher(); BtnX.Enabled = true;
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnCBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		#endregion
		#region Symbols
		private void BtnPlus_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "+";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnX.Enabled = true;
			BtnOBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnMinus_Click(object sender, EventArgs e)
		{
			TBFunction.Text += "-";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnX.Enabled = true;
			BtnOBracket.Enabled = true;
			BtnKoma.Enabled = false;
		}
		private void BtnOBracket_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "(";
			Operator.Button_switcher();
			BtnX.Enabled = true;
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnMinus.Enabled = true;
			BtnKoma.Enabled = true;
		}
		private void BtnCBracket_Click(object sender, EventArgs e)
		{
			Operator.Breakets--;
			TBFunction.Text += ")";
			Operator.Button_switcher(false);
			BtnCBracket.Enabled = Operator.Breakets != 0;
			BtnMinus.Enabled = true;
			BtnPlus.Enabled = true;
			BtnPower.Enabled = true;
		}
		private void BtnSegmentator_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "/(";
			Operator.Button_switcher();
			BtnX.Enabled = true;
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnMinus.Enabled = true;
			BtnKoma.Enabled = true;
		}
		private void BtnPower_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "^(";
			Operator.Button_switcher();
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnMinus.Enabled = true;
			BtnKoma.Enabled = true;
		}
		private void BtnMultiply_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			TBFunction.Text += "*(";
			Operator.Button_switcher();
			BtnX.Enabled = true;
			Operator.Button_switcher(Operator.SpecialSymbols_Buttons, false);
			BtnOBracket.Enabled = true;
			BtnMinus.Enabled = true;
			BtnKoma.Enabled = false;
		}
		#endregion
		#endregion
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Operator.currentFunctions = Operator.Functions[listBox1.SelectedIndex];
			Operator.currentChoise = listBox1.SelectedIndex;
			FuncActions funcActions = new FuncActions();
			funcActions.Show();
		}
	}
}