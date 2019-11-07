﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using Picture_Puzzle_1._0.MyClass;

namespace Picture_Puzzle_1._0
{
    public partial class Main : Form
    {
<<<<<<< HEAD
        int countline = 0; //
=======
        int countline ;

>>>>>>> 6a82d866c1c9dee28469fd499277a088b7141967
        MainGame myGame = new MainGame();
        public Main()
        {
            InitializeComponent();
<<<<<<< HEAD
=======
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            proBar.Enabled = false;
>>>>>>> 6a82d866c1c9dee28469fd499277a088b7141967
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();

        }

        private void btnstartG_Click(object sender, EventArgs e)
        {
            runtext.Text = "";
            pnGame.Controls.Clear();
            showlv.Text = "";
<<<<<<< HEAD
            labC.Text = "0"; // update late
=======
            labC.Text = "";
            proBar.Enabled = true ;
>>>>>>> 6a82d866c1c9dee28469fd499277a088b7141967
            countline = 0;
            this.timer1.Start();

            //load size
            switch (Convert.ToInt32(Box1.Text.ToString()))
            {
                case 0:
                    {
                        DialogResult error1 = MessageBox.Show("Bạn chưa chọn level chơi, mặc định là 3x3 nhé ", "Bình tĩnh", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (error1 == DialogResult.OK)
                        {
                            Box1.Focus();
                            Refresh();
                        }
                    }
                    break;
                case 1:
                    {
                        myGame.setSize(3);
                        showlv.Text = "3x3";
                    }
                    break;
                case 2:
                    {
                        myGame.setSize(4);
                        showlv.Text = "4x4";
                    }
                    break;
                case 3:
                    {
                        myGame.setSize(5);
                        showlv.Text = "5x5";
                    }
                    break;
            }
            myGame.Createbutton();
            Addnewbutton();

            //load image from FORM
            Image orginal;
            orginal = Properties.Resources.anime;
            pnsample.BackgroundImage = orginal;

            //set image for game
            myGame.setImage(orginal);
            
            foreach (Button bt in pnGame.Controls)
            {
                bt.Enabled = true;
                bt.Click += new EventHandler(MovePlay);
            }
            myGame.cropImageTomages(pnGame.Width, pnGame.Height);
            Addnewimage();
        }

        private void Addnewimage()
        {
            
            int i = 0;
            int[] arr = new int[(myGame.getSize() * myGame.getSize()) -1];
            for (int j = 0; j < (myGame.getSize() * myGame.getSize()) -1; j++)
            {
                arr[j] = j;
            }
			arr = ran(arr);
            foreach (Button b in pnGame.Controls)
            {
                if (i < arr.Length)
                {
                    b.Image = (Image)myGame.getImages()[arr[i]];
					b.Text = arr[i].ToString();
                    i++;
                }
            }
		}
		private void Addnewbutton()
        {
            int[] arrr = new int[myGame.getSize()* myGame.getSize()];
			for (int i = 0; i < myGame.getSize() * myGame.getSize(); i++)
            {
                arrr[i] = i;
				pnGame.Controls.Add((Button)myGame.getButton()[arrr[i]]);
            }
        }
        private int[] ran(int[] arr)
        {
            Random rand = new Random();
            arr = arr.OrderBy(x => rand.Next()).ToArray();
            return arr;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
        }

        private bool Check()
		{
			foreach (Button btn in pnGame.Controls) 
			{
				if (btn.TabIndex.ToString() != btn.Text)
				{
					return false;
				}
			}
			return true;
        }
		private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kết thúc Chương Trình", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //no code
            }
        }
        public void MovePlay(Object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            if (btn.Image == null)
                return;
            Button emply_btn = null;
            foreach (Button bt in this.pnGame.Controls)
            {
                if (bt.Image == null)
                {
                    emply_btn = bt;
                    break;
                }
            }
            if (btn.TabIndex == (emply_btn.TabIndex - 1) ||
                btn.TabIndex == (emply_btn.TabIndex - myGame.getSize()) ||
                btn.TabIndex == (emply_btn.TabIndex + 1) ||
                btn.TabIndex == (emply_btn.TabIndex + myGame.getSize()))
            {
				swap(emply_btn, btn);
				countline++;								// update late
				labC.Text = Convert.ToString(countline);	// update late
			}
			if (Check() == true)
			{
				timer1.Stop();
				MessageBox.Show("Bạn đã chiến thắng ",
					"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
<<<<<<< HEAD
				frmWiner frmWin = new frmWiner(labC.Text, Box1.Text);	// update late
				frmWin.ShowDialog();									// update late
=======
                timer2.Enabled = true;
                timer3.Enabled = true;
                timer4.Enabled = true;
                runtext.Text = "You Win !!";
>>>>>>> 6a82d866c1c9dee28469fd499277a088b7141967
			}
		}

        private void timer1_Tick(object sender, EventArgs e)
        {
			this.proBar.Increment(1);
		}
		public void swap(Button a, Button b)
		{
			string temp = a.Text;
			a.Text = b.Text;
			b.Text = temp;
			Image i = a.Image;
			a.Image = b.Image;
			b.Image = i;
		}

<<<<<<< HEAD
		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void datatable_Click(object sender, EventArgs e)
		{
			HighScore highScore = new HighScore();
			highScore.ShowDialog();
		}
	}
=======
		private void timer1_Tick(object sender, EventArgs e)
        {
            this.proBar.Increment(1);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.runtext.ForeColor = Color.Red;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.runtext.ForeColor = Color.Blue;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            this.runtext.ForeColor = Color.Yellow;
        }

        private void endgame_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            runtext.Text = "You Lose !!";
            MessageBox.Show("Bạn đã chịu thua rồi, Click ''Start Game'' để bất đầu lại nào, cố lên ",
                    "Ôi Không", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
>>>>>>> 6a82d866c1c9dee28469fd499277a088b7141967
}
