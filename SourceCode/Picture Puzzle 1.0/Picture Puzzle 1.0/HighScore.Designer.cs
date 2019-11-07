namespace Picture_Puzzle_1._0
{
	partial class HighScore
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
			this.dGVScore = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dGVScore)).BeginInit();
			this.SuspendLayout();
			// 
			// dGVScore
			// 
			this.dGVScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGVScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Count,
            this.Level});
			this.dGVScore.Location = new System.Drawing.Point(12, 12);
			this.dGVScore.Name = "dGVScore";
			this.dGVScore.Size = new System.Drawing.Size(247, 230);
			this.dGVScore.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(64, 248);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(151, 59);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Đóng";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// UserName
			// 
			this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.UserName.DataPropertyName = "UserName";
			this.UserName.HeaderText = "User Name";
			this.UserName.Name = "UserName";
			// 
			// Count
			// 
			this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Count.DataPropertyName = "Count";
			this.Count.HeaderText = "Count";
			this.Count.Name = "Count";
			this.Count.Width = 60;
			// 
			// Level
			// 
			this.Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.Level.DataPropertyName = "Lv";
			this.Level.HeaderText = "Level";
			this.Level.Name = "Level";
			this.Level.Width = 58;
			// 
			// HighScore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(275, 316);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dGVScore);
			this.Name = "HighScore";
			this.Text = "HighScore";
			this.Load += new System.EventHandler(this.HighScore_Load);
			((System.ComponentModel.ISupportInitialize)(this.dGVScore)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dGVScore;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
		private System.Windows.Forms.DataGridViewTextBoxColumn Level;
	}
}