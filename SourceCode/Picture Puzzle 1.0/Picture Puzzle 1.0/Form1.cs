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
        public Main()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnstartG_Click(object sender, EventArgs e)
        {
            pnGame.Controls.Clear();
            showlv.Text = "";
            labC.Text = "";
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

        private void Check()
		{
            int dem = 0;
            foreach (Button btn in pnGame.Controls)
            {
                
            }
            if (dem == (myGame.getSize()* myGame.getSize()) -1)
                MessageBox.Show("You Win !");
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
                emply_btn.BackColor = Color.White;
                btn.BackColor = Color.White;
                emply_btn.Image = btn.Image;
                btn.Image = null;
                countline++;
                labC.Text = Convert.ToString(countline);
            }
            Check();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.proBar.Increment(1);
        }
    }
}
