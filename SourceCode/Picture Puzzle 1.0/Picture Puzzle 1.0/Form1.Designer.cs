namespace Picture_Puzzle_1._0
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnGame = new System.Windows.Forms.Panel();
            this.pncontrol = new System.Windows.Forms.Panel();
            this.cbimage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.ComboBox();
            this.btnstartG = new System.Windows.Forms.Button();
            this.pnsample = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datatable = new System.Windows.Forms.ToolStripMenuItem();
            this.aBoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labC = new System.Windows.Forms.Label();
            this.labcount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showlv = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Sound = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pncontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnsample)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnGame
            // 
            this.pnGame.BackColor = System.Drawing.Color.Transparent;
            this.pnGame.BackgroundImage = global::Picture_Puzzle_1._0.Properties.Resources.khung1;
            this.pnGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnGame.Location = new System.Drawing.Point(325, 178);
            this.pnGame.Margin = new System.Windows.Forms.Padding(2);
            this.pnGame.Name = "pnGame";
            this.pnGame.Size = new System.Drawing.Size(360, 360);
            this.pnGame.TabIndex = 0;
            // 
            // pncontrol
            // 
            this.pncontrol.BackgroundImage = global::Picture_Puzzle_1._0.Properties.Resources.BackGround_Control2;
            this.pncontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pncontrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pncontrol.Controls.Add(this.cbimage);
            this.pncontrol.Controls.Add(this.label2);
            this.pncontrol.Controls.Add(this.exit);
            this.pncontrol.Controls.Add(this.label1);
            this.pncontrol.Controls.Add(this.Box1);
            this.pncontrol.Controls.Add(this.btnstartG);
            this.pncontrol.Location = new System.Drawing.Point(13, 384);
            this.pncontrol.Margin = new System.Windows.Forms.Padding(2);
            this.pncontrol.Name = "pncontrol";
            this.pncontrol.Size = new System.Drawing.Size(308, 183);
            this.pncontrol.TabIndex = 1;
            // 
            // cbimage
            // 
            this.cbimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbimage.FormattingEnabled = true;
            this.cbimage.Location = new System.Drawing.Point(127, 77);
            this.cbimage.Name = "cbimage";
            this.cbimage.Size = new System.Drawing.Size(125, 28);
            this.cbimage.TabIndex = 4;
            this.cbimage.SelectedValueChanged += new System.EventHandler(this.cbimage_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Image :";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(152, 120);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(150, 60);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Level :";
            // 
            // Box1
            // 
            this.Box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box1.FormattingEnabled = true;
            this.Box1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Box1.Location = new System.Drawing.Point(127, 37);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(50, 28);
            this.Box1.TabIndex = 2;
            this.Box1.Text = "1";
            // 
            // btnstartG
            // 
            this.btnstartG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstartG.BackgroundImage")));
            this.btnstartG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstartG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstartG.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstartG.ForeColor = System.Drawing.Color.Red;
            this.btnstartG.Location = new System.Drawing.Point(3, 120);
            this.btnstartG.Name = "btnstartG";
            this.btnstartG.Size = new System.Drawing.Size(150, 60);
            this.btnstartG.TabIndex = 0;
            this.btnstartG.Text = "Start Game";
            this.btnstartG.UseVisualStyleBackColor = true;
            this.btnstartG.Click += new System.EventHandler(this.btnstartG_Click);
            // 
            // pnsample
            // 
            this.pnsample.BackColor = System.Drawing.Color.Transparent;
            this.pnsample.BackgroundImage = global::Picture_Puzzle_1._0.Properties.Resources.khung2;
            this.pnsample.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnsample.Location = new System.Drawing.Point(120, 178);
            this.pnsample.Name = "pnsample";
            this.pnsample.Size = new System.Drawing.Size(200, 200);
            this.pnsample.TabIndex = 2;
            this.pnsample.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.datatable,
            this.aBoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // datatable
            // 
            this.datatable.Name = "datatable";
            this.datatable.Size = new System.Drawing.Size(51, 20);
            this.datatable.Text = "Player";
            this.datatable.Click += new System.EventHandler(this.datatable_Click);
            // 
            // aBoutToolStripMenuItem
            // 
            this.aBoutToolStripMenuItem.Name = "aBoutToolStripMenuItem";
            this.aBoutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aBoutToolStripMenuItem.Text = "&ABout";
            this.aBoutToolStripMenuItem.Click += new System.EventHandler(this.aBoutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labC);
            this.panel1.Controls.Add(this.labcount);
            this.panel1.Location = new System.Drawing.Point(16, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 98);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labC
            // 
            this.labC.AutoSize = true;
            this.labC.BackColor = System.Drawing.Color.Transparent;
            this.labC.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labC.Location = new System.Drawing.Point(35, 37);
            this.labC.Name = "labC";
            this.labC.Size = new System.Drawing.Size(26, 29);
            this.labC.TabIndex = 6;
            this.labC.Text = "0";
            // 
            // labcount
            // 
            this.labcount.AutoSize = true;
            this.labcount.BackColor = System.Drawing.Color.Transparent;
            this.labcount.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcount.Location = new System.Drawing.Point(17, 9);
            this.labcount.Name = "labcount";
            this.labcount.Size = new System.Drawing.Size(71, 21);
            this.labcount.TabIndex = 5;
            this.labcount.Text = "Count :";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.showlv);
            this.panel2.Location = new System.Drawing.Point(16, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 98);
            this.panel2.TabIndex = 8;
            // 
            // showlv
            // 
            this.showlv.AutoSize = true;
            this.showlv.BackColor = System.Drawing.Color.Transparent;
            this.showlv.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showlv.Location = new System.Drawing.Point(23, 30);
            this.showlv.Name = "showlv";
            this.showlv.Size = new System.Drawing.Size(53, 29);
            this.showlv.TabIndex = 3;
            this.showlv.Text = "3x3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Picture_Puzzle_1._0.Properties.Resources.br22;
            this.pictureBox1.Location = new System.Drawing.Point(569, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.Sound);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(13, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 132);
            this.panel3.TabIndex = 9;
            // 
            // Sound
            // 
            this.Sound.BackColor = System.Drawing.Color.White;
            this.Sound.BackgroundImage = global::Picture_Puzzle_1._0.Properties.Resources.logoSound;
            this.Sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sound.ForeColor = System.Drawing.Color.Black;
            this.Sound.Location = new System.Drawing.Point(635, 90);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(30, 32);
            this.Sound.TabIndex = 11;
            this.Sound.UseVisualStyleBackColor = false;
            this.Sound.Click += new System.EventHandler(this.Sound_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Moonstar", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 52);
            this.label4.TabIndex = 12;
            this.label4.Text = "2019";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Moonstar", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 52);
            this.label3.TabIndex = 11;
            this.label3.Text = "Picture Puzzle";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Picture_Puzzle_1._0.Properties.Resources._111;
            this.pictureBox2.Location = new System.Drawing.Point(107, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 400;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 600;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(326, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Game by Ho Quoc Dat and Trinh Nguyen Hoang Vinh Phuc";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Picture_Puzzle_1._0.Properties.Resources.br33;
            this.ClientSize = new System.Drawing.Size(697, 579);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnsample);
            this.Controls.Add(this.pncontrol);
            this.Controls.Add(this.pnGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Game Xếp Hình Anime";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.pncontrol.ResumeLayout(false);
            this.pncontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnsample)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnGame;
        private System.Windows.Forms.Panel pncontrol;
        private System.Windows.Forms.PictureBox pnsample;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBoutToolStripMenuItem;
        private System.Windows.Forms.Button btnstartG;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Box1;
        private System.Windows.Forms.Label showlv;
        private System.Windows.Forms.Label labC;
        private System.Windows.Forms.Label labcount;
		private System.Windows.Forms.ToolStripMenuItem datatable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbimage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Sound;
    }
}

