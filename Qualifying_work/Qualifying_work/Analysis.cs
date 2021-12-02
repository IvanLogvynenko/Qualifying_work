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
	public partial class Analysis : Form
	{
		public Analysis()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Analizer analizer = new Analizer(Operator.currentFunctions, new Range(-5,5));
			label1.Text = analizer.DomainFunction 
				+ "\n" + analizer.FunctionRange 
				+ "\n" + analizer.IntersectionAxes
				+ "\n" + analizer.Rising
				+ "\n" + analizer.Falling;
		}
		private void Analysis_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				Hide();
			}
		}
        private void Analysis_Load(object sender, EventArgs e)
        {

        }
    }
}
