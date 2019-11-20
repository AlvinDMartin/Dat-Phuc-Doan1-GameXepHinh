using System;
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
        int countline = 0;
        MainGame myGame = new MainGame();
        Image orginal;
        string extention = ".jpg";
        
        public Main()
        {
            InitializeComponent();
            loadimageGame();

        }

        private void cbimage_SelectedValueChanged(object sender, EventArgs e)
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
            pnGame.Controls.Clear();
            showlv.Text = "";
            labC.Text = "0";
            countline = 0;
            this.timer1.Start();
            //load size
            switch (Convert.ToInt32(Box1.Text.ToString()))
            {
                case 0:
                    {
                        DialogResult error1 = MessageBox.Show("Chọn Level trước khi chơi nào. (>_<)", "Bình tĩnh", MessageBoxButtons.OK, MessageBoxIcon.None);
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

            //Start action Game
            foreach (Button bt in pnGame.Controls)
            {
                bt.Enabled = true;
                bt.Click += new EventHandler(MovePlay);
            }

            RandomGame();
        }

        private void Addnewimage()
        {
            
            int i = 0;
            int[] arr = new int[(myGame.getSize() * myGame.getSize()) -1];
            for (int j = 0; j < (myGame.getSize() * myGame.getSize()) -1; j++)
            {
                arr[j] = j;
            }			
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


        //private int[] ran(int[] arr)
        //{
        //    Random rand = new Random();
        //    arr = arr.OrderBy(x => rand.Next()).ToArray();
        //    return arr;
        //}


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
				frmWiner frmWin = new frmWiner();	// update late
                frmWin.CT(labC.Text, Box1.Text);
                //labC.Text, Box1.Text

                frmWin.ShowDialog();// update late
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
			HighScore highScore = new HighScore();
			highScore.ShowDialog();
		}

        public void loadimageGame()
        {
            List<string> ListImage = new List<string>() { "anime", "anime2", "anime3" };

            cbimage.DataSource = ListImage;
        }

        public void RandomGame()
        {
            Button emply = null;
            Button test = null;
            foreach (Button bt in this.pnGame.Controls)
            {
                if (bt.Image == null)
                {
                    emply = bt;
                    break;
                }
            }
            if (btn.TabIndex == (emply.TabIndex - 1) ||
                btn.TabIndex == (emply.TabIndex - myGame.getSize()) ||
                btn.TabIndex == (emply.TabIndex + 1) ||
                btn.TabIndex == (emply.TabIndex + myGame.getSize()))
            {
                swap(emply, btn);
                countline++;                                // update late
                labC.Text = Convert.ToString(countline);    // update late
            }
        }
	}
}
