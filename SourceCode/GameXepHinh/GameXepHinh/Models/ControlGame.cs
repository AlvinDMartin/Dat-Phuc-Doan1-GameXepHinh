using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace GameXepHinh.Models
{
    public partial class ControlGame
    {
        
        Point emplyX = 0;
        Point emplyY = 0;
        
        public void UP(Button Emply)
        {

        }
        public void DOWN()
        {

        }
        public void LEFT()
        {

        }
        public void FIGHT()
        {

        }
        public void swap(button a, Button b)
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
    }
}
