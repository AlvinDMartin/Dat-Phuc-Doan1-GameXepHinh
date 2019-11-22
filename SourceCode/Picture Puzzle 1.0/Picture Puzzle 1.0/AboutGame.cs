using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Puzzle_1._0
{
    public partial class AboutGame : Form
    {
        Graphics gp;
        private Rectangle rRect;
        private SizeF stringSize = new SizeF();
        private Font fFont3 = new Font("Clear Sans", 10, FontStyle.Bold);
        private Font fFont2 = new Font("Clear Sans", 11, FontStyle.Bold);
        private Font fFont1 = new Font("Clear Sans", 14, FontStyle.Bold);
        public AboutGame()
        {
            InitializeComponent();
            gp = this.panelAbout.CreateGraphics();
            rRect = new Rectangle(0, 0, 500, 500);
        }
        public void DrawText(Graphics g, String sText, Font nFont, SolidBrush nSolidBrush, SolidBrush nSolidBrush2, int X, int Y)
        {
            stringSize = gp.MeasureString(sText, nFont);
            gp.DrawString(sText, nFont, nSolidBrush, new PointF(X - stringSize.Width / 2 + 1, Y + 1));
            gp.DrawString(sText, nFont, nSolidBrush2, new PointF(X - stringSize.Width / 2, Y));
        }

        private void panelAbout_Paint(object sender, PaintEventArgs e)
        {
            gp.FillRectangle(new SolidBrush(Color.FromArgb(128, 255, 162, 89)), rRect);
            DrawText(gp, "ABOUT GAME - PICTURE PUZZLE 2019", fFont1, new SolidBrush(Color.FromArgb(255, 10, 10, 10)), new SolidBrush(Color.Chocolate), 188, 20);
            DrawText(gp, "GAME XEP HINH - C#", fFont2, new SolidBrush(Color.FromArgb(255, 10, 10, 10)), new SolidBrush(Color.Chocolate), 188, 60);
            DrawText(gp, "HO QUOC DAT - 17110117", fFont2, new SolidBrush(Color.FromArgb(255, 10, 10, 10)), new SolidBrush(Color.Chocolate), 188, 100);
            DrawText(gp, "TRINH NGUYEN HOANG VINH PHUC - 17110208", fFont2, new SolidBrush(Color.FromArgb(255, 10, 10, 10)), new SolidBrush(Color.Chocolate), 188, 140);
            DrawText(gp, "UNIVERSITY OF TECHNOLOGY AND EDUCATION", fFont2, new SolidBrush(Color.FromArgb(255, 10, 10, 10)), new SolidBrush(Color.Chocolate), 188, 180);
            DrawText(gp, "DO AN 1 - CONG NGHE THONG TIN", fFont2, new SolidBrush(Color.FromArgb(255, 10, 10, 10)), new SolidBrush(Color.Chocolate), 188, 220);
            DrawText(gp, "20-11-2019", fFont2, new SolidBrush(Color.FromArgb(255, 10, 10, 10)), new SolidBrush(Color.Chocolate), 188, 260);
        }


        private void AboutGame_Load(object sender, EventArgs e)
        {

        }
    }
}
