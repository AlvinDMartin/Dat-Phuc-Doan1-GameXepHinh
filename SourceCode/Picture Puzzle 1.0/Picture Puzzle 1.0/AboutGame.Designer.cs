namespace Picture_Puzzle_1._0
{
    partial class AboutGame
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
            this.panelAbout = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = System.Drawing.Color.Transparent;
            this.panelAbout.Location = new System.Drawing.Point(198, 12);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(391, 426);
            this.panelAbout.TabIndex = 0;
            this.panelAbout.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAbout_Paint);
            // 
            // AboutGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Picture_Puzzle_1._0.Properties.Resources.br33;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.panelAbout);
            this.Name = "AboutGame";
            this.Text = "About Game";
            this.Load += new System.EventHandler(this.AboutGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAbout;
    }
}