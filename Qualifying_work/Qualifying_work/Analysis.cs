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
		Bitmap bitmap;
		KoordinationSystem koordinationSystem;
		bool start = true;
		Analizer analizer;
		public Analysis()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			analizer = new Analizer(Operator.currentFunctions, new Range(-5,5));
			label1.Text = analizer.DomainFunction +
				analizer.IsOdd +
				analizer.IntersectionAxes +
				analizer.HigherX +
				analizer.LowerX +
				analizer.Extrem +
				analizer.Rising +
				analizer.Falling +
				analizer.InflectionPoints +
				analizer.InflectionPlus +
				analizer.InflectionMinus;
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
			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			koordinationSystem = new KoordinationSystem(new Area(-5, 5, -5, 5, 1), new Area(0, pictureBox1.Width, 0, pictureBox1.Height));
			timer1.Interval = 1;
			timer1.Start();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (start)
			{
				koordinationSystem.BuildSystem(true, bitmap);
				koordinationSystem.BuildFuncton(Operator.currentFunctions, bitmap);
				koordinationSystem.BuildDerivate(Operator.currentFunctions, bitmap);
				koordinationSystem.BuildSecondDerivate(Operator.currentFunctions, bitmap);
				pictureBox1.Image = bitmap;
				start = false;
			}
		}
        private void Analysis_SizeChanged(object sender, EventArgs e)
        {
			label1.Size = new Size(label1.Size.Width, this.Height - 40);
        }
    }
}
