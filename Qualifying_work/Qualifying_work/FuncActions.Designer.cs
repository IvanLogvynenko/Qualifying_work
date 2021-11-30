
namespace Qualifying_work
{
	partial class FuncActions
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.BtnAnalize = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAnalize
            // 
            this.BtnAnalize.Location = new System.Drawing.Point(12, 35);
            this.BtnAnalize.Name = "BtnAnalize";
            this.BtnAnalize.Size = new System.Drawing.Size(152, 39);
            this.BtnAnalize.TabIndex = 0;
            this.BtnAnalize.Text = "Analize";
            this.BtnAnalize.UseVisualStyleBackColor = true;
            this.BtnAnalize.Click += new System.EventHandler(this.BtnAnalize_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(170, 35);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(147, 39);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnChange
            // 
            this.BtnChange.Location = new System.Drawing.Point(220, 35);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(98, 39);
            this.BtnChange.TabIndex = 0;
            this.BtnChange.Text = "Change";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // FuncActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 84);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.BtnAnalize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FuncActions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FuncActions_FormClosing);
            this.Load += new System.EventHandler(this.FuncActions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnAnalize;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.Button BtnChange;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
	}
}