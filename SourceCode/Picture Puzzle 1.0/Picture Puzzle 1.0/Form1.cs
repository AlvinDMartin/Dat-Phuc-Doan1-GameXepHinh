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
using System.Media;

namespace Picture_Puzzle_1._0
{
    public partial class Main : Form
    {
        SoundPlayer s = new SoundPlayer(Properties.Resources.SoundG);
        SoundPlayer sw = new SoundPlayer(Properties.Resources.SoundWin);
        SoundPlayer sl = new SoundPlayer(Properties.Resources.SoundLose);

        int countline = 0;
        MainGame myGame;
        Image orginal;
        string extention = ".jpg";
        Button emply_btn = null;
        int[] marker = new int[4];
        public static Main Instance = null;// add singleton pattern to refactor code

        public Main()
        {
            Instance = this;
            myGame = new MainGame();
            InitializeComponent();
            loadimageGame();

        }
        public Panel GetPanel()
        {
            return pnGame;
        }

        private void cbimage_SelectedValueChanged(object sender, EventArgs e) //ham load background anh
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedValue != null)
            {
                Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\" + cb.SelectedValue.ToString() + extention);
                orginal = bm;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        private void btnstartG_Click(object sender, EventArgs e)
        {
            s.PlayLooping();
            pnGame.Controls.Clear();
            Sound.BackColor = Color.LimeGreen;
            showlv.Text = "";
            labC.Text = "0";
            countline = 0;

            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;

            //load size

            switch (Convert.ToInt32(Box1.Text.ToString()))
            {

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

            //Add Button
            myGame.Createbutton();
            Addnewbutton();

            //load image from FORM
            pnsample.BackgroundImage = orginal;

            //set image for Game
            myGame.setImage(orginal);
            
            //Cut and Add Image for Game
            myGame.cropImageTomages(pnGame.Width, pnGame.Height);
            Addnewimage();

            //Shuffle();
            //RandomGame();

            //Start action Game
            foreach (Button bt in pnGame.Controls)
            {
                bt.Enabled = true;
                bt.Click += new EventHandler(MovePlay);
            }

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



        public void Shuffle()
        {
            int kt = myGame.getSize() * myGame.getSize();
            int[] arr = new int[kt - 1];
            int q = 0;
            int i, j, RN;
            //int[] a = new int[kt];
            Boolean flag = false;
            i = 0;

            for (int k = 0; k < kt - 1; k++)
            {
                arr[k] = k;
            }

            do
            {
                Random rnd = new Random();
                RN = Convert.ToInt32((rnd.Next(0, kt-1)) + 1);
                for (j = 0; j <= i; j++)
                {
                    if (arr[j] == RN)
                    {
                        flag = true;
                        break;
                    }

                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    arr[i] = RN;
                    i++;
                }
            }
            while (i <= kt-1);
            foreach (Button b in pnGame.Controls)
            {
                if (q < arr.Length)
                {
                    b.Image = (Image)myGame.getImages()[arr[arr[q]]];
                    b.Text = arr[arr[q]].ToString();
                    q++;
                }
            }
        }



        private void Form1_Click(object sender, EventArgs e)
        {
            
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

        private bool modcheck(int a, int b)
        {

            return (a % b == 0) ? true : false;

        }
        public void MovePlay(Object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            if (btn.Image == null)
                return;
           
            foreach (Button bt in this.pnGame.Controls)
            {
                if (bt.Image == null)
                {
                    emply_btn = bt;
                    break;
                }
            }
            bool skip = false;
            
            if ((modcheck(btn.TabIndex, myGame.getSize()) && btn.TabIndex != 0 && emply_btn.TabIndex == btn.TabIndex - 1)
                || (modcheck(btn.TabIndex + 1, myGame.getSize()) && btn.TabIndex != 0 && emply_btn.TabIndex == btn.TabIndex + 1))
            {
                skip = true;
            }
            else if (btn.TabIndex == (emply_btn.TabIndex - 1) ||
                btn.TabIndex == (emply_btn.TabIndex - myGame.getSize()) ||
                btn.TabIndex == (emply_btn.TabIndex + 1) ||
                btn.TabIndex == (emply_btn.TabIndex + myGame.getSize()))
            {
                if(skip != true)
                {
                    swap(emply_btn, btn);
                    countline++;                                // update late
                    labC.Text = Convert.ToString(countline);    // update late
                    skip = false;
                }
                
            }
			if (Check() == true)
			{
                s.Stop();
                sw.Play();
				MessageBox.Show("You WIN WIN WIN !! ",
                    "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmWiner frmWin = new frmWiner();	// update late
                frmWin.CT(labC.Text, Box1.Text);
                //labC.Text, Box1.Text

                frmWin.ShowDialog();// update late

			}
		}

        

        public void swap(Button a, Button b)
		{
			string temp = a.Text;
			a.Text = b.Text;
			b.Text = temp;

            Image i = a.Image;
			a.Image = b.Image;
			b.Image = i;

            int xx1 = a.Location.X;
            int yy1 = a.Location.Y;
            int xx2 = b.Location.X;
            int yy2 = b.Location.Y;
            int p1 = xx1;
            xx1 = xx2;
            xx2 = p1;
            int p2 = yy1;
            yy1 = yy2;
            yy2 = p2;

        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void datatable_Click(object sender, EventArgs e)
		{
			PLayer highScore = new PLayer();
			highScore.ShowDialog();
		}

        public void loadimageGame()
        {
            List<string> ListImage = new List<string>() { "anime", "anime2", "anime3" };

            cbimage.DataSource = ListImage;
        }

        public void RandomGame()            //Mo rong chua dung den
        {
            Button emply = new Button();
            Button test = new Button();

            for (int i = 0; i < (myGame.getSize() * myGame.getSize()) - 1; i++)
            {
                int a = 0;
                foreach (Button bt in this.pnGame.Controls)
                {
                    if (bt.Image == null)
                    {
                        emply = bt;
                        if (bt.TabIndex == (myGame.getSize() * myGame.getSize()) - 1 || bt.TabIndex == (myGame.getSize() * myGame.getSize()) - 2)
                        {
                            a = bt.TabIndex - 1;
                            break;
                        }
                        else if (bt.TabIndex == (myGame.getSize() * myGame.getSize()) - 3 || bt.TabIndex == (myGame.getSize() * myGame.getSize()) - 6)
                        {
                            a = bt.TabIndex - myGame.getSize();
                            break;
                        }
                        else if (bt.TabIndex == 0 || bt.TabIndex == (myGame.getSize() * myGame.getSize()) - 8)
                        {
                            a = bt.TabIndex + 1;
                            break;
                        }
                        else if (bt.TabIndex == (myGame.getSize() * myGame.getSize()) - 7 || bt.TabIndex == (myGame.getSize() * myGame.getSize()) - 4)
                        {
                            a = bt.TabIndex + myGame.getSize();
                            break;
                        }
                        break;
                    }
                }
                foreach (Button bt in this.pnGame.Controls)
                {
                    if (bt.TabIndex == a)
                    {
                        test = bt;
                        swap(emply, test);
                        break;
                    }
                }
            }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnstartG_Click(null, null);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.label3.ForeColor = Color.Red;
            this.label4.ForeColor = Color.Red;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.label3.ForeColor = Color.Yellow;
            this.label4.ForeColor = Color.Yellow;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            this.label3.ForeColor = Color.Blue;
            this.label4.ForeColor = Color.Blue;
        }

        public bool canMove(int pos)        //mo rong chua dung den
        {
            if (pos < 0 || pos > myGame.getSize()) return false;

            return false;
        }

        private void Sound_Click(object sender, EventArgs e)
        {
            
            Bitmap on = new Bitmap(Properties.Resources.logoSound);
            Bitmap off = new Bitmap(Properties.Resources.logoSoundOff);
            if (Sound.BackColor ==Color.LimeGreen)
            {
                s.Stop();
                Sound.BackColor = Color.Red;
                Sound.BackgroundImage = off;
            }
            else if (Sound.BackColor == Color.Red)
            {
                s.Play();
                Sound.BackColor = Color.LimeGreen;
                Sound.BackgroundImage = on;
            }
        }

        private void aBoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutGame ab = new AboutGame();
            ab.ShowDialog();
        }
    }

}
