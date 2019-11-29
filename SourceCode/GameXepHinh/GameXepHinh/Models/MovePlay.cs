using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameXepHinh.Models
{
    public partial class MovePlay
    {
        LoadSize _size = new LoadSize();
        Button Emply = new Button();

        int emplyX = 0;
        int emplyY = 0;

        int X = 0;
        int Y = 0;

        int tabFull = 0;
        int tabEmply = 0;


        public bool UP( Button Emply , Button full, LoadSize getsize)
        {
            _size = getsize;
            emplyX = Emply.Location.X;
            emplyY = Emply.Location.Y;

            X = full.Location.X;
            Y = full.Location.Y;

            tabFull = full.TabIndex;
            tabEmply = Emply.TabIndex;

            if (tabFull == (tabEmply - 1) ||
                tabFull == (tabEmply - _size.getSize()) ||
                tabFull == (tabEmply + 1) ||
                tabFull == (tabEmply + _size.getSize()))
            {
                if (emplyX == X && emplyY == (Y - 360 / _size.getSize()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool DOWN(Button Emply, Button full, LoadSize getsize)
        {
            _size = getsize;
            emplyX = Emply.Location.X;
            emplyY = Emply.Location.Y;

            X = full.Location.X;
            Y = full.Location.Y;

            tabFull = full.TabIndex;
            tabEmply = Emply.TabIndex;

            if (tabFull == (tabEmply - 1) ||
                tabFull == (tabEmply - _size.getSize()) ||
                tabFull == (tabEmply + 1) ||
                tabFull == (tabEmply + _size.getSize()))
            {
                if (emplyX == X && emplyY == (Y + 360 / _size.getSize()))
                {
                    //swap(Emply, full);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool LEFT(Button Emply , Button full, LoadSize getsize)
        {
            _size = getsize;
            emplyX = Emply.Location.X;
            emplyY = Emply.Location.Y;

            X = full.Location.X;
            Y = full.Location.Y;

            tabFull = full.TabIndex;
            tabEmply = Emply.TabIndex;

            if (tabFull == (tabEmply - 1) ||
                tabFull == (tabEmply - _size.getSize()) ||
                tabFull == (tabEmply + 1) ||
                tabFull == (tabEmply + _size.getSize()))
            {
                if (emplyY == Y && emplyX == (X + 360 / _size.getSize()))
                {
                    //swap(Emply, full);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool RIGHT(Button Emply, Button full, LoadSize getsize)
        {
            _size = getsize;
            emplyX = Emply.Location.X;
            emplyY = Emply.Location.Y;

            X = full.Location.X;
            Y = full.Location.Y;

            tabFull = full.TabIndex;
            tabEmply = Emply.TabIndex;

            if (tabFull == (tabEmply - 1) ||
                tabFull == (tabEmply - _size.getSize()) ||
                tabFull == (tabEmply + 1) ||
                tabFull == (tabEmply + _size.getSize()))
            {
                if (emplyY == Y && emplyX == (X - 360 / _size.getSize()))
                {
                    //swap(Emply, full);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
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
    }
}
