
namespace Qualifying_work
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
            this.ShowingBtn = new System.Windows.Forms.Button();
            this.tBFunction = new System.Windows.Forms.TextBox();
            this.btnArcctg = new System.Windows.Forms.Button();
            this.btnKoma = new System.Windows.Forms.Button();
            this.btnArctg = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnArccos = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnArcsin = new System.Windows.Forms.Button();
            this.btnCtg = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnCBracket = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnTg = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnOBracket = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnSegmentator = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlProVersion = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlProVersion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Enabled = false;
            this.btnBackSpace.Location = new System.Drawing.Point(463, 62);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(116, 86);
            this.btnBackSpace.TabIndex = 33;
            this.btnBackSpace.Text = "←";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(407, 60);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(50, 176);
            this.btnLog.TabIndex = 27;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Enabled = false;
            this.btnEnter.Location = new System.Drawing.Point(463, 152);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(116, 86);
            this.btnEnter.TabIndex = 32;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(12, 33);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(35, 24);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "y =";
            // 
            // ShowingBtn
            // 
            this.ShowingBtn.Location = new System.Drawing.Point(288, 3);
            this.ShowingBtn.Name = "ShowingBtn";
            this.ShowingBtn.Size = new System.Drawing.Size(24, 24);
            this.ShowingBtn.TabIndex = 0;
            this.ShowingBtn.Text = "^";
            this.ShowingBtn.UseVisualStyleBackColor = true;
            this.ShowingBtn.Click += new System.EventHandler(this.ShowingBtn_Click);
            // 
            // tBFunction
            // 
            this.tBFunction.Location = new System.Drawing.Point(53, 30);
            this.tBFunction.Name = "tBFunction";
            this.tBFunction.Size = new System.Drawing.Size(526, 29);
            this.tBFunction.TabIndex = 1;
            this.tBFunction.TextChanged += new System.EventHandler(this.tBFunction_TextChanged);
            // 
            // btnArcctg
            // 
            this.btnArcctg.Location = new System.Drawing.Point(321, 196);
            this.btnArcctg.Name = "btnArcctg";
            this.btnArcctg.Size = new System.Drawing.Size(80, 40);
            this.btnArcctg.TabIndex = 31;
            this.btnArcctg.Text = "arcctg";
            this.btnArcctg.UseVisualStyleBackColor = true;
            this.btnArcctg.Click += new System.EventHandler(this.btnArcctg_Click);
            // 
            // btnKoma
            // 
            this.btnKoma.Location = new System.Drawing.Point(97, 196);
            this.btnKoma.Name = "btnKoma";
            this.btnKoma.Size = new System.Drawing.Size(40, 40);
            this.btnKoma.TabIndex = 16;
            this.btnKoma.Text = ",";
            this.btnKoma.UseVisualStyleBackColor = true;
            this.btnKoma.Click += new System.EventHandler(this.btnKoma_Click);
            // 
            // btnArctg
            // 
            this.btnArctg.Location = new System.Drawing.Point(321, 150);
            this.btnArctg.Name = "btnArctg";
            this.btnArctg.Size = new System.Drawing.Size(80, 40);
            this.btnArctg.TabIndex = 30;
            this.btnArctg.Text = "arctg";
            this.btnArctg.UseVisualStyleBackColor = true;
            this.btnArctg.Click += new System.EventHandler(this.btnArctg_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(189, 196);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(40, 40);
            this.btnX.TabIndex = 23;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnArccos
            // 
            this.btnArccos.Location = new System.Drawing.Point(321, 106);
            this.btnArccos.Name = "btnArccos";
            this.btnArccos.Size = new System.Drawing.Size(80, 40);
            this.btnArccos.TabIndex = 28;
            this.btnArccos.Text = "arccos";
            this.btnArccos.UseVisualStyleBackColor = true;
            this.btnArccos.Click += new System.EventHandler(this.btnArccos_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(7, 150);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 40);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnArcsin
            // 
            this.btnArcsin.Location = new System.Drawing.Point(321, 60);
            this.btnArcsin.Name = "btnArcsin";
            this.btnArcsin.Size = new System.Drawing.Size(80, 40);
            this.btnArcsin.TabIndex = 34;
            this.btnArcsin.Text = "arcsin";
            this.btnArcsin.UseVisualStyleBackColor = true;
            this.btnArcsin.Click += new System.EventHandler(this.btnArcsin_Click);
            // 
            // btnCtg
            // 
            this.btnCtg.Location = new System.Drawing.Point(235, 198);
            this.btnCtg.Name = "btnCtg";
            this.btnCtg.Size = new System.Drawing.Size(80, 40);
            this.btnCtg.TabIndex = 29;
            this.btnCtg.Text = "ctg";
            this.btnCtg.UseVisualStyleBackColor = true;
            this.btnCtg.Click += new System.EventHandler(this.btnCtg_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(7, 196);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(85, 40);
            this.btn0.TabIndex = 6;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnCBracket
            // 
            this.btnCBracket.Location = new System.Drawing.Point(189, 105);
            this.btnCBracket.Name = "btnCBracket";
            this.btnCBracket.Size = new System.Drawing.Size(40, 40);
            this.btnCBracket.TabIndex = 19;
            this.btnCBracket.Text = ")";
            this.btnCBracket.UseVisualStyleBackColor = true;
            this.btnCBracket.Click += new System.EventHandler(this.btnCBracket_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(235, 60);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(80, 40);
            this.btnSin.TabIndex = 25;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(235, 106);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(80, 40);
            this.btnCos.TabIndex = 26;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(52, 150);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 40);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnTg
            // 
            this.btnTg.Location = new System.Drawing.Point(235, 152);
            this.btnTg.Name = "btnTg";
            this.btnTg.Size = new System.Drawing.Size(80, 40);
            this.btnTg.TabIndex = 35;
            this.btnTg.Text = "tg";
            this.btnTg.UseVisualStyleBackColor = true;
            this.btnTg.Click += new System.EventHandler(this.btnTg_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(97, 60);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 40);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(189, 150);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(40, 40);
            this.btnPower.TabIndex = 17;
            this.btnPower.Text = "^";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(52, 60);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 40);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnOBracket
            // 
            this.btnOBracket.Location = new System.Drawing.Point(189, 60);
            this.btnOBracket.Name = "btnOBracket";
            this.btnOBracket.Size = new System.Drawing.Size(40, 40);
            this.btnOBracket.TabIndex = 24;
            this.btnOBracket.Text = "(";
            this.btnOBracket.UseVisualStyleBackColor = true;
            this.btnOBracket.Click += new System.EventHandler(this.btnOBracket_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(7, 105);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 40);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(97, 105);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 40);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(52, 105);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 40);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(143, 60);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(40, 40);
            this.btnPlus.TabIndex = 22;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(97, 150);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 40);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(7, 60);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 40);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(143, 105);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(40, 40);
            this.btnMinus.TabIndex = 18;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnSegmentator
            // 
            this.btnSegmentator.Location = new System.Drawing.Point(143, 196);
            this.btnSegmentator.Name = "btnSegmentator";
            this.btnSegmentator.Size = new System.Drawing.Size(40, 40);
            this.btnSegmentator.TabIndex = 20;
            this.btnSegmentator.Text = "/";
            this.btnSegmentator.UseVisualStyleBackColor = true;
            this.btnSegmentator.Click += new System.EventHandler(this.btnSegmentator_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(143, 150);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(40, 40);
            this.btnMultiply.TabIndex = 21;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(606, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(311, 484);
            this.listBox1.TabIndex = 9;
            // 
            // pnlProVersion
            // 
            this.pnlProVersion.Controls.Add(this.btnBackSpace);
            this.pnlProVersion.Controls.Add(this.btnLog);
            this.pnlProVersion.Controls.Add(this.btnEnter);
            this.pnlProVersion.Controls.Add(this.lblY);
            this.pnlProVersion.Controls.Add(this.ShowingBtn);
            this.pnlProVersion.Controls.Add(this.tBFunction);
            this.pnlProVersion.Controls.Add(this.btnArcctg);
            this.pnlProVersion.Controls.Add(this.btnKoma);
            this.pnlProVersion.Controls.Add(this.btnArctg);
            this.pnlProVersion.Controls.Add(this.btnX);
            this.pnlProVersion.Controls.Add(this.btnArccos);
            this.pnlProVersion.Controls.Add(this.btn1);
            this.pnlProVersion.Controls.Add(this.btnArcsin);
            this.pnlProVersion.Controls.Add(this.btnCtg);
            this.pnlProVersion.Controls.Add(this.btn0);
            this.pnlProVersion.Controls.Add(this.btnCBracket);
            this.pnlProVersion.Controls.Add(this.btnSin);
            this.pnlProVersion.Controls.Add(this.btnCos);
            this.pnlProVersion.Controls.Add(this.btn2);
            this.pnlProVersion.Controls.Add(this.btnTg);
            this.pnlProVersion.Controls.Add(this.btn9);
            this.pnlProVersion.Controls.Add(this.btnPower);
            this.pnlProVersion.Controls.Add(this.btn8);
            this.pnlProVersion.Controls.Add(this.btnOBracket);
            this.pnlProVersion.Controls.Add(this.btn4);
            this.pnlProVersion.Controls.Add(this.btn6);
            this.pnlProVersion.Controls.Add(this.btn5);
            this.pnlProVersion.Controls.Add(this.btnPlus);
            this.pnlProVersion.Controls.Add(this.btn3);
            this.pnlProVersion.Controls.Add(this.btn7);
            this.pnlProVersion.Controls.Add(this.btnMinus);
            this.pnlProVersion.Controls.Add(this.btnSegmentator);
            this.pnlProVersion.Controls.Add(this.btnMultiply);
            this.pnlProVersion.Location = new System.Drawing.Point(0, 250);
            this.pnlProVersion.Name = "pnlProVersion";
            this.pnlProVersion.Size = new System.Drawing.Size(600, 250);
            this.pnlProVersion.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(600, 475);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 500);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pnlProVersion);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlProVersion.ResumeLayout(false);
            this.pnlProVersion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnBackSpace;
		private System.Windows.Forms.Button btnLog;
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Label lblY;
		private System.Windows.Forms.Button ShowingBtn;
		private System.Windows.Forms.TextBox tBFunction;
		private System.Windows.Forms.Button btnArcctg;
		private System.Windows.Forms.Button btnKoma;
		private System.Windows.Forms.Button btnArctg;
		private System.Windows.Forms.Button btnX;
		private System.Windows.Forms.Button btnArccos;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btnArcsin;
		private System.Windows.Forms.Button btnCtg;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btnCBracket;
		private System.Windows.Forms.Button btnSin;
		private System.Windows.Forms.Button btnCos;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btnTg;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btnPower;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btnOBracket;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btnMinus;
		private System.Windows.Forms.Button btnSegmentator;
		private System.Windows.Forms.Button btnMultiply;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Panel pnlProVersion;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

