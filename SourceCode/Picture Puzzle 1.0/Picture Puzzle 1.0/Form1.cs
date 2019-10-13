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

namespace Picture_Puzzle_1._0
{
    public partial class Form1 : Form
    {
        Point EmptyPoint;
        ArrayList images = new ArrayList();

        public Form1()
        {
            EmptyPoint.X = 240;
            EmptyPoint.Y = 240;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnstartG_Click(object sender, EventArgs e)
        {
            foreach (Button b in pnGame.Controls)
                b.Enabled = true;
            Image orginal = Properties.Resources.anime;

            cropImageTomages(orginal, 360, 360);

            Addnewimage(images);
        }

        private void Addnewimage(ArrayList images)
        {
            int i = 0;
            int[] arr = {  0, 1, 2, 3, 4, 5, 6, 7};
            arr = suffle(arr);

            foreach(Button b in pnGame.Controls)
            {
                if(i<arr.Length)
                {
                    b.Image = (Image)images[arr[i]];
                    i++;
                }
            }
        }

        private int[] suffle(int[] arr)
        {
            Random rand = new Random();
            arr = arr.OrderBy(x => rand.Next()).ToArray();

            return arr;
        }

        private void cropImageTomages(Image orginal, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics gra = Graphics.FromImage(bmp);
            gra.DrawImage(orginal, 0, 0, w, h);
            gra.Dispose();

            int movr = 0, movd = 0;
            for(int k = 0; k<8; k++)
            {
                Bitmap piece = new Bitmap(120, 120);

                for (int i = 0; i < 120; i++)
                    for (int j = 0; j < 120; j++)
                        piece.SetPixel(i, j, bmp.GetPixel(i + movr,j + movd));
                images.Add(piece);

                movr += 120;
                if(movr == 360)
                {
                    movr = 0;
                    movd += 120;
                }
            }   

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Moveimage((Button)sender);
;        }

        private void Moveimage(Button btn)
        {
            if(((btn.Location.X==EmptyPoint.X-120||btn.Location.X==EmptyPoint.X+120)
                &&btn.Location.Y==EmptyPoint.Y)
               ||(btn.Location.Y == EmptyPoint.Y - 120 || btn.Location.Y == EmptyPoint.Y + 120)
                &&btn.Location.X == EmptyPoint.X)
            {
                Point s = btn.Location;
                btn.Location = EmptyPoint;
                EmptyPoint = s;
            }

			if (EmptyPoint.X == 240 && EmptyPoint.Y == 240)
				Check();

		}

		private void Check()
		{
			int dem = 0, index;
			foreach (Button btn in pnGame.Controls)
			{
				index = (btn.Location.Y / 120) * 3 + btn.Location.X / 120;
				if ((Image)images[index] == btn.Image)
					dem++;
			}
			if (dem == 8)
				MessageBox.Show("You Win !");
		}
	}
}
