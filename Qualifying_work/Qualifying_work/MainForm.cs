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
			Operator.LaunchingProgram = true;
			Operator.Renew = true;
			Operator.ChartArea = new ChartArea();
			Operator.Breakets = 0;
			timer1.Interval = 10;
			timer1.Start();
		}
		private void btnEnter_Click(object sender, EventArgs e)
		{
			try
			{
				Polynomial polynomial = new Polynomial(tBFunction.Text);
				Operator.Polynomials.Add(polynomial);
				chart1.Series.Clear();
				foreach (Series serie in Operator.SeriesRenew())
				{
					chart1.Series.Add(serie);
				}
			}
			catch (StackOverflowException){}
			tBFunction.Text = "";
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (Operator.LaunchingProgram)
			{
				chart1.Series.Clear();
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
				Operator.LaunchingProgram = false;
			}
			if (Operator.Renew)
			{
				chart1.ChartAreas[0] = Operator.ChartArea;
				Operator.Renew = false;
			}
		}
		private void tBFunction_TextChanged(object sender, EventArgs e)
		{
			btnEnter.Enabled = (Operator.Breakets == 0) && (tBFunction.Text != "");
			btnBackSpace.Enabled = tBFunction.Text != "";
		}
		#region All buttons
		private void btnBackSpace_Click(object sender, EventArgs e)
		{
			tBFunction.Text = Operator.BackSpace(tBFunction.Text);
			Operator.Breakets = 0;
			foreach (char item in tBFunction.Text)
			{
				if (item == '(')
					Operator.Breakets++;
				if (item == ')')
					Operator.Breakets--;
			}
		}
		private void ShowingBtn_Click(object sender, EventArgs e)
		{
			if (Operator.IsPanelOpened)
			{
				Operator.IsPanelOpened = false;
				ShowingBtn.Text = "↓";
				for (int i = 0; i < 22; i++)
				{
					pnlProVersion.Location = new Point(pnlProVersion.Location.X, pnlProVersion.Location.Y + 10);
				}
			}
			else
			{
				Operator.IsPanelOpened = true;
				ShowingBtn.Text = "^";
				for (int i = 0; i < 22; i++)
				{
					pnlProVersion.Location = new Point(pnlProVersion.Location.X, pnlProVersion.Location.Y - 10);
				}
			}
		}
		private void btnMultiply_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			tBFunction.Text += "*(";
		}
		private void btnX_Click(object sender, EventArgs e)
		{
			tBFunction.Text += "x";
		}
		private void btnSegmentator_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			tBFunction.Text += "/(";
		}
		private void btnPower_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			tBFunction.Text += "^(";
		}
		private void btn0_Click(object sender, EventArgs e)
		{
			tBFunction.Text += '0'.ToString();
		}
		private void btn1_Click(object sender, EventArgs e)
		{
			tBFunction.Text += "1";
		}
		private void btn2_Click(object sender, EventArgs e)
		{
			tBFunction.Text += "2";
		}
		private void btn3_Click(object sender, EventArgs e)
		{
			tBFunction.Text += "3";
		}
		private void btn4_Click(object sender, EventArgs e)
		{
			tBFunction.Text += "4";
		}
		private void btn5_Click(object sender, EventArgs e)
		{
			tBFunction.Text += "5";
		}
		private void btn6_Click(object sender, EventArgs e)
		{
			tBFunction.Text += "6";
		}
		private void btn7_Click(object sender, EventArgs e)
		{
			tBFunction.Text += "7";
		}
		private void btn8_Click(object sender, EventArgs e)
		{
			tBFunction.Text += "8";
		}
		private void btn9_Click(object sender, EventArgs e)
		{
			tBFunction.Text += "9";
		}
		private void btnSin_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			tBFunction.Text += "Sin(";
		}
		private void btnCos_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			tBFunction.Text += "Cos(";
		}
		private void btnTg_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			tBFunction.Text += "Tg(";
		}
		private void btnCtg_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			tBFunction.Text += "Ctg(";
		}
		private void btnArcsin_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			tBFunction.Text += "Arcsin(";
		}
		private void btnArccos_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			tBFunction.Text += "Arccos(";
		}
		private void btnArctg_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			tBFunction.Text += "Arctg(";
		}
		private void btnArcctg_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			tBFunction.Text += "Arcctg(";
		}
		private void btnLog_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			tBFunction.Text += "Log(";
		}
		private void btnPlus_Click(object sender, EventArgs e)
		{
			tBFunction.Text += "+";
		}
		private void btnMinus_Click(object sender, EventArgs e)
		{
			tBFunction.Text += "-";
		}
		private void btnOBracket_Click(object sender, EventArgs e)
		{
			Operator.Breakets++;
			tBFunction.Text += "(";
		}
		private void btnCBracket_Click(object sender, EventArgs e)
		{
			Operator.Breakets--;
			tBFunction.Text += ")";
		}
		private void btnKoma_Click(object sender, EventArgs e)
		{
			tBFunction.Text += ",";
		}
		#endregion
	}
}
