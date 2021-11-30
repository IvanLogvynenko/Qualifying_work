using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qualifying_work
{
	public class KoordinationSystem
	{
		public Area Area { get; set; }
		public Area AreaI;
		public Graphics Graphics { get; set; }
		public KoordinationSystem(Area Area, Area AreaI)
		{
			this.Area = Area;
			this.Graphics = Graphics.FromImage(Operator.Bitmap);
			this.AreaI = AreaI;
		}
		public int Xtoi(double x)
		{
			int ii;
			ii = (int)AreaI.XMin + (int)((x - Area.XMin) * ((AreaI.XMax - AreaI.XMin) / (Area.XMax - Area.XMin)));
			return ii;
		}
		public int Ytoj(double y)
		{
			int jj;
			jj = (int)AreaI.YMax + (int)((y - Area.YMin) * (AreaI.YMin - AreaI.YMax) / (Area.YMax - Area.YMin));
			return jj;
		}
		public void BuildSystem(bool points)
		{
			Graphics.Clear(Color.White);
			Pen LinesPen = new Pen(Brushes.LightBlue, 1) { DashStyle = DashStyle.Dash };
			for (double i = 0; i < Area.XMax; i += Area.Step)
			{
				Graphics.DrawLine(LinesPen, Xtoi(i), Ytoj(Area.YMax), Xtoi(i), Ytoj(Area.YMin));
			}
			for (double i = 0; i > Area.XMin; i -= Area.Step)
			{
				Graphics.DrawLine(LinesPen, Xtoi(i), Ytoj(Area.YMax), Xtoi(i), Ytoj(Area.YMin));
			}
			for (double i = 0; i < Area.YMax; i += Area.Step)
			{
				Graphics.DrawLine(LinesPen, Xtoi(Area.XMin), Ytoj(i), Xtoi(Area.XMax), Ytoj(i));
			}
			for (double i = 0; i > Area.YMin; i -= Area.Step)
			{
				Graphics.DrawLine(LinesPen, Xtoi(Area.XMin), Ytoj(i), Xtoi(Area.XMax), Ytoj(i));
			}
			Pen AxisPen = new Pen(Brushes.Black, 2) { StartCap = LineCap.Triangle, EndCap = LineCap.ArrowAnchor };
			Graphics.DrawLine(AxisPen, Xtoi(Area.XMin), Ytoj(0), Xtoi(Area.XMax), Ytoj(0));
			Graphics.DrawLine(AxisPen, Xtoi(0), Ytoj(Area.YMin), Xtoi(0), Ytoj(Area.YMax));
			Font font = new Font("tahoma", 10, FontStyle.Regular);
			if (points)
			{
				Numbers();
			}
			else
			{
				Pi();
			}
			Graphics.DrawString("0", font, Brushes.DarkBlue, new Point(Xtoi(0.2), Ytoj(0.5)));
			Graphics.DrawString("Y", font, Brushes.DarkBlue, new Point(Xtoi(0.3), Ytoj(Area.XMax - 0.3)));
			Graphics.DrawString("X", font, Brushes.DarkBlue, new Point(Xtoi(Area.YMax - 0.3), Ytoj(0.5)));
		}
		public void Pi()
		{
			Font ftn1 = new Font("arial", 10, FontStyle.Regular);
			string s = "";
			for (int p = 1; p <= Area.XMax; p++)
			{
				if (p != 1)
				{
					if (p % 2 == 0)
					{
						s = (p / 2).ToString() + "π";
					}
					else
					{
						s = p.ToString() + "π/2";
					}
				}
				else
				{
					s = "π/2";
				}
				Graphics.DrawString(s, ftn1, Brushes.DarkBlue, new Point(Xtoi(p * (Math.PI / 2) - 0.3), Ytoj(-0.4)));
			}
			for (int p = -1; p >= Area.XMin; p--)
			{
				if (p != -1)
				{
					if (p % 2 == 0)
					{
						s = (p / 2).ToString() + "π";
					}
					else
					{
						s = p.ToString() + "π/2";
					}
				}
				else
				{
					s = "-π/2";
				}
				Graphics.DrawString(s, ftn1, Brushes.DarkBlue, new Point(Xtoi(p * (Math.PI / 2) - 0.3), Ytoj(-0.4)));
			}
			for (int p = 1; p <= Area.YMax; p++)
			{
				Graphics.DrawString(p.ToString(), ftn1, Brushes.DarkBlue, new Point(Xtoi(-0.3), Ytoj(p + 0.3)));
			}
			for (int p = -1; p >= Area.YMin; p--)
			{
				Graphics.DrawString(p.ToString(), ftn1, Brushes.DarkBlue, new Point(Xtoi(-0.3), Ytoj(p + 0.3)));
			}
			Graphics.DrawString("0", ftn1, Brushes.DarkBlue, new Point(Xtoi(0.2), Ytoj(0.5)));
		}
		public void Numbers()
		{
			Font ftn1 = new Font("arial", 10, FontStyle.Regular);
			for (double p = Area.Step; p <= Area.XMax; p += Area.Step)
			{
				Graphics.DrawString(p.ToString(), ftn1, Brushes.DarkBlue, new Point(Xtoi(p - 0.3), Ytoj(-0.1)));
			}
			for (double p = -1 * Area.Step; p >= Area.XMin; p -= Area.Step)
			{
				Graphics.DrawString(p.ToString(), ftn1, Brushes.DarkBlue, new Point(Xtoi(p - 0.3), Ytoj(-0.1)));
			}
			for (double p = Area.Step; p <= Area.YMax; p += Area.Step)
			{
				Graphics.DrawString(p.ToString(), ftn1, Brushes.DarkBlue, new Point(Xtoi(-0.3), Ytoj(p + 0.3)));
			}
			for (double p = -1 * Area.Step; p >= Area.YMin; p -= Area.Step)
			{
				Graphics.DrawString(p.ToString(), ftn1, Brushes.DarkBlue, new Point(Xtoi(-0.3), Ytoj(p + 0.3)));
			}
			Graphics.DrawString("0", ftn1, Brushes.DarkBlue, new Point(Xtoi(0.2), Ytoj(0.5)));
		}
		public void BuildFuncton(Function function)
		{
			Pen pen = new Pen(function.Color, 3);
			this.Graphics.DrawLines(pen, function.Points);
			Operator.Renew = true;
		}
	}
	public class Area
	{
		public double XMax { get; set; }
		public double YMax { get; set; }
		public double XMin { get; set; }
		public double YMin { get; set; }
		public double Step { get; set; }
		public Area(double XMin, double XMax, double YMin, double YMax, double Step)
		{
			this.XMax = XMax;
			this.XMin = XMin;
			this.YMax = YMax;
			this.YMin = YMin;
			this.Step = Step;
		}
		public Area(double XMin, double XMax, double YMin, double YMax)
		{
			this.XMax = XMax;
			this.XMin = XMin;
			this.YMax = YMax;
			this.YMin = YMin;
		}
	}
}