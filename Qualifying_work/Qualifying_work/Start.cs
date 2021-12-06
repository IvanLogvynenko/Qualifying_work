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
	public partial class Start : Form
	{
		public Start()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Theory theory = new Theory();
			if (!Operator.IsTheoryOpened)
			{
				theory.Show();
			}
			Operator.IsTheoryOpened = true;
		}
		private void button2_Click(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			if (!Operator.IsMainFormOpened)
			{
				mainForm.Show();
			}
			Operator.IsMainFormOpened = true;
		}
	}
}