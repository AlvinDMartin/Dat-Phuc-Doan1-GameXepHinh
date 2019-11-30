using GameXepHinh.Models;
using GameXepHinh.MyForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameXepHinh
{
    public partial class Form1 : Form
    {
        SoundPlayer s = new SoundPlayer(Application.StartupPath + "//Resources//sounds//SoundG.wav");
        SoundPlayer sw = new SoundPlayer(Application.StartupPath + "//Resources//sounds//SoundWin.wav");
        SoundPlayer sl = new SoundPlayer(Application.StartupPath + "//Resources//sounds//SoundLose.wav");
        Bitmap on = new Bitmap(Image.FromFile(Application.StartupPath + "//Resources//images//logoSound.png"));
        Bitmap off = new Bitmap(Image.FromFile(Application.StartupPath + "//Resources//images//logoSoundOff.png"));
       
        Image orginal;
        int countline = 0;

        LoadSize _Loadsize;
        LoadImageOriginal _LoadImageOrignal;
        LoadButton _LoadButton;
        LoadCropImage _LoadCropImage;
        MovePlay _MovePlay;
        RandomPlay _RandomPlay;

        YourNameWinner Winner;
        ScorePlaylist Score;


        public Form1()
        {
            InitializeComponent();

            _Loadsize = new LoadSize();
            _LoadImageOrignal = new LoadImageOriginal();
            _LoadButton = new LoadButton();
            _LoadCropImage = new LoadCropImage();
            _MovePlay = new MovePlay();
            _RandomPlay = new RandomPlay();

            Winner = new YourNameWinner();
            Score = new ScorePlaylist();

            cbimage.DataSource = _LoadImageOrignal.getImageOriginal();

        }
 
        

//==================== BUTTON ====================================
        private void btnstartG_Click(object sender, EventArgs e)
        {
            s.PlayLooping();
            pnGame.Controls.Clear();
            Sound.BackColor = Color.LimeGreen;
            Sound.BackgroundImage = on;
            showlv.Text = "";
            labC.Text = "0";
            pnsample.BackgroundImage = orginal;

            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;


//------------------------chon level cho game--------------------------------------
            switch (Convert.ToInt32(Box1.Text.ToString()))
            {

                case 1:
                    {
                        _Loadsize.setSize(3);
                        showlv.Text = "3x3";
                    }
                    break;
                case 2:
                    {
                        _Loadsize.setSize(4);
                        showlv.Text = "4x4";
                    }
                    break;
                case 3:
                    {
                        _Loadsize.setSize(5);
                        showlv.Text = "5x5";
                    }
                    break;
            }


//----------------------------Add Button---------------------------------------------
            _LoadButton.Createbutton(_Loadsize);
            Addnewbutton();


//----------------------------Add Image----------------------------------------
            // ===load original image
            _LoadCropImage.setImage(orginal);
            // ===Crop
            _LoadCropImage.cropImageTomages(pnGame.Width, pnGame.Height, _Loadsize);
            Addnewimage();


//----------------------------shuffle-------------------------------------------
            for (int k = 0; k <= 50; k++)
            {
                RandomGame();
            }



            foreach (Button bt in pnGame.Controls)
            {
                bt.Enabled = true;
                bt.Click += new EventHandler(MovePlay);
            }

        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnstartG_Click(null, null);
        }
        private void aBoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutGame ab = new AboutGame();
            ab.ShowDialog();
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
        private void cbimage_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                Bitmap bm = new Bitmap(Image.FromFile(Application.StartupPath + "\\Resources\\images\\" + cb.SelectedValue.ToString() + ".jpg"));
                orginal = bm;
            }
        }
        private void datatable_Click(object sender, EventArgs e)
        {
            Score.ShowDialog();
        }

        //================================================================





        //=============== SET SOUND ======================================
        private void Sound_Click(object sender, EventArgs e)
        {

            if (Sound.BackColor == Color.LimeGreen)
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
//================================================================






//=============== SET RUN COLOR ==================================
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
//================================================================




//=============== FUNCTION =======================================
        private void Addnewbutton()
        {
            int[] arrr = new int[_Loadsize.getSize() * _Loadsize.getSize()];
            for (int i = 0; i < _Loadsize.getSize() * _Loadsize.getSize(); i++)
            {
                arrr[i] = i;
                pnGame.Controls.Add((Button)_LoadButton.getButton()[arrr[i]]);
            }
        }
        private void Addnewimage()
        {

            int i = 0;
            int[] arr = new int[(_Loadsize.getSize() * _Loadsize.getSize()) - 1];
            for (int j = 0; j < (_Loadsize.getSize() * _Loadsize.getSize()) - 1; j++)
            {
                arr[j] = j;
            }
            foreach (Button b in pnGame.Controls)
            {
                if (i < arr.Length)
                {
                    b.Image = (Image)_LoadCropImage.getImages()[arr[i]];
                    b.Text = arr[i].ToString();
                    i++;
                }
            }
        }
        private void RandomGame()
        {
            int i = 0;
            int s = _Loadsize.getSize() * _Loadsize.getSize();

            Button emply_btn = null;
            Button[] arrButton = new Button[s];


            foreach (Button bt in this.pnGame.Controls)
            {
                if (bt.Image == null)
                {
                    emply_btn = bt;
                    arrButton[i] = bt;
                }
                else
                {
                    arrButton[i] = bt;                   
                }
                i++;
            }

            for (int j = 0; j < s; j++)
            {
                _RandomPlay.ran(emply_btn, arrButton[j], _Loadsize);
            }
            _RandomPlay.SwapRan(emply_btn);


        }
        private void MovePlay(Object sender, EventArgs e) 
        {
            Button emply_btn = null;
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

            if (_MovePlay.UP(emply_btn, btn, _Loadsize) == true || 
                _MovePlay.DOWN(emply_btn, btn, _Loadsize) == true ||
                _MovePlay.LEFT(emply_btn, btn, _Loadsize) == true || 
                _MovePlay.RIGHT(emply_btn, btn, _Loadsize) == true)
            {
                _MovePlay.swap(emply_btn, btn);
                countline++;                               
                labC.Text = Convert.ToString(countline);
            }
            if (Check() == true)
            {
                s.Stop();
                sw.Play();
                MessageBox.Show("You WIN WIN WIN !! ",
                    "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Winner.CT(labC.Text, Box1.Text);
                Winner.ShowDialog();

            }

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

        //================================================================
    }
}
