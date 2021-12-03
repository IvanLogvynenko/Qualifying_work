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
	public partial class Theory : Form
	{
		public Theory()
		{
			InitializeComponent();
		}
		int i = 1;
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (i == 3)
			{
				label1.Text = "загрузка";
				i = 0;
			}
			label1.Text += '.';
			i++;
		}
	}
}
