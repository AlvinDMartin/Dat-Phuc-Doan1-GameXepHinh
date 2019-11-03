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
            this.pnGame = new System.Windows.Forms.Panel();
            this.pncontrol = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.btnstartG = new System.Windows.Forms.Button();
            this.pnsample = new System.Windows.Forms.PictureBox();
            this.proBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labC = new System.Windows.Forms.Label();
            this.labcount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScoreG = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showlv = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pncontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnsample)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnGame
            // 
            this.pnGame.BackColor = System.Drawing.Color.Transparent;
            this.pnGame.Location = new System.Drawing.Point(325, 178);
            this.pnGame.Margin = new System.Windows.Forms.Padding(2);
            this.pnGame.Name = "pnGame";
            this.pnGame.Size = new System.Drawing.Size(360, 360);
            this.pnGame.TabIndex = 0;
            // 
            // pncontrol
            // 
            this.pncontrol.BackgroundImage = global::Picture_Puzzle_1._0.Properties.Resources.br_control;
            this.pncontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pncontrol.Controls.Add(this.exit);
            this.pncontrol.Controls.Add(this.btnstartG);
            this.pncontrol.Location = new System.Drawing.Point(13, 384);
            this.pncontrol.Margin = new System.Windows.Forms.Padding(2);
            this.pncontrol.Name = "pncontrol";
            this.pncontrol.Size = new System.Drawing.Size(308, 183);
            this.pncontrol.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = global::Picture_Puzzle_1._0.Properties.Resources.br_button;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Goofball", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(156, 120);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(150, 60);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnstartG
            // 
            this.btnstartG.BackgroundImage = global::Picture_Puzzle_1._0.Properties.Resources.br_button;
            this.btnstartG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstartG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstartG.Font = new System.Drawing.Font("Goofball", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pnsample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnsample.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnsample.Location = new System.Drawing.Point(120, 178);
            this.pnsample.Name = "pnsample";
            this.pnsample.Size = new System.Drawing.Size(200, 200);
            this.pnsample.TabIndex = 2;
            this.pnsample.TabStop = false;
            // 
            // proBar
            // 
            this.proBar.Location = new System.Drawing.Point(325, 544);
            this.proBar.Name = "proBar";
            this.proBar.Size = new System.Drawing.Size(360, 23);
            this.proBar.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aBoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // aBoutToolStripMenuItem
            // 
            this.aBoutToolStripMenuItem.Name = "aBoutToolStripMenuItem";
            this.aBoutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aBoutToolStripMenuItem.Text = "&ABout";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labC);
            this.panel1.Controls.Add(this.labcount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ScoreG);
            this.panel1.Location = new System.Drawing.Point(16, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 98);
            this.panel1.TabIndex = 7;
            // 
            // labC
            // 
            this.labC.AutoSize = true;
            this.labC.Font = new System.Drawing.Font("Nightporter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labC.Location = new System.Drawing.Point(71, 69);
            this.labC.Name = "labC";
            this.labC.Size = new System.Drawing.Size(16, 17);
            this.labC.TabIndex = 6;
            this.labC.Text = "0";
            // 
            // labcount
            // 
            this.labcount.AutoSize = true;
            this.labcount.Font = new System.Drawing.Font("Nife Fiter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcount.Location = new System.Drawing.Point(7, 74);
            this.labcount.Name = "labcount";
            this.labcount.Size = new System.Drawing.Size(61, 12);
            this.labcount.TabIndex = 5;
            this.labcount.Text = "count :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nife Fiter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // ScoreG
            // 
            this.ScoreG.AutoSize = true;
            this.ScoreG.Font = new System.Drawing.Font("Nife Fiter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreG.Location = new System.Drawing.Point(14, 10);
            this.ScoreG.Name = "ScoreG";
            this.ScoreG.Size = new System.Drawing.Size(73, 17);
            this.ScoreG.TabIndex = 0;
            this.ScoreG.Text = "Score";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.showlv);
            this.panel2.Controls.Add(this.Box1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 98);
            this.panel2.TabIndex = 8;
            // 
            // showlv
            // 
            this.showlv.AutoSize = true;
            this.showlv.Font = new System.Drawing.Font("Nife Fiter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showlv.Location = new System.Drawing.Point(30, 70);
            this.showlv.Name = "showlv";
            this.showlv.Size = new System.Drawing.Size(38, 14);
            this.showlv.TabIndex = 3;
            this.showlv.Text = "3x3";
            // 
            // Box1
            // 
            this.Box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box1.FormattingEnabled = true;
            this.Box1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Box1.Location = new System.Drawing.Point(26, 36);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(50, 28);
            this.Box1.TabIndex = 2;
            this.Box1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nife Fiter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Level";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Picture_Puzzle_1._0.Properties.Resources.backgroundGame2;
            this.ClientSize = new System.Drawing.Size(697, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.proBar);
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
            ((System.ComponentModel.ISupportInitialize)(this.pnsample)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnGame;
        private System.Windows.Forms.Panel pncontrol;
        private System.Windows.Forms.PictureBox pnsample;
        private System.Windows.Forms.ProgressBar proBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBoutToolStripMenuItem;
        private System.Windows.Forms.Button btnstartG;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ScoreG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Box1;
        private System.Windows.Forms.Label showlv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labC;
        private System.Windows.Forms.Label labcount;
        private System.Windows.Forms.Timer timer1;
    }
}

