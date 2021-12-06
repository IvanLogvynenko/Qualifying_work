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
		private void Theory_Load(object sender, EventArgs e)
		{
			webBrowser1.Navigate($@"{Application.StartupPath}/theory.html");
		}
		private void Theory_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				Hide();
				Operator.IsTheoryOpened = false;
			}
		}
	}
}