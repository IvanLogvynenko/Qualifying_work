﻿using System;
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
	public partial class FuncActions : Form
	{
		public FuncActions()
		{
			InitializeComponent();
		}
		private void FuncActions_Load(object sender, EventArgs e)
		{
			label1.Text = Operator.currentFunctions.ToString();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			FuncChange funcChange = new FuncChange();
			funcChange.Show();
			Hide();
		}
		private void FuncActions_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				Hide();
				Operator.IsFuncActionOpened = false;
			}
		}
		private void BtnDelete_Click(object sender, EventArgs e)
		{
			Operator.Functions.Remove(Operator.currentFunctions);
			Hide();
			Operator.koordinationSystem.Renew();
		}
		private void BtnAnalize_Click(object sender, EventArgs e)
		{
			if (!Operator.IsAnalysisOpened)
			{
				Analysis analysis = new Analysis();
				analysis.Show();
			}
			Operator.IsAnalysisOpened = true;
		}
	}
}