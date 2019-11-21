namespace Picture_Puzzle_1._0
{
	partial class frmWiner
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtLevel = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lb1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtLevel);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtCount);
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lb1);
			this.panel1.Location = new System.Drawing.Point(43, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 173);
			this.panel1.TabIndex = 0;
			// 
			// txtLevel
			// 
			this.txtLevel.Location = new System.Drawing.Point(133, 108);
			this.txtLevel.Name = "txtLevel";
			this.txtLevel.Size = new System.Drawing.Size(108, 20);
			this.txtLevel.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(46, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Level";
			// 
			// txtCount
			// 
			this.txtCount.Location = new System.Drawing.Point(133, 60);
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(108, 20);
			this.txtCount.TabIndex = 3;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(132, 36);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(109, 20);
			this.txtName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(46, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số bước";
			// 
			// lb1
			// 
			this.lb1.AutoSize = true;
			this.lb1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lb1.Location = new System.Drawing.Point(46, 36);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(31, 17);
			this.lb1.TabIndex = 0;
			this.lb1.Text = "Tên";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(48, 41);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(80, 49);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(161, 41);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(80, 49);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Không Lưu";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnClose);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Location = new System.Drawing.Point(43, 191);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(300, 150);
			this.panel2.TabIndex = 3;
			// 
			// frmWiner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "frmWiner";
			this.Text = "frmWiner";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtCount;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lb1;
		private System.Windows.Forms.TextBox txtLevel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel panel2;
    }
}