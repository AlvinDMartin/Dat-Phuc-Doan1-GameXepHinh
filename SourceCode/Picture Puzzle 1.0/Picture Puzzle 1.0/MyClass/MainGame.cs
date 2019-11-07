using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public struct Tile
{
    public Button btn;
    public Bitmap img;
} ;
namespace Picture_Puzzle_1._0.MyClass
{
    
    public partial class MainGame : Form
    {
        ArrayList m_ButtonList = new ArrayList();
        ArrayList m_ImageList = new ArrayList();
        int m_SizeMap = 3;// default = 3x3
        Image m_Image;
        

        public void cropImageTomages( int w, int h)
        {
            m_ImageList.Clear();
            Bitmap bmp = new Bitmap(w, h);
            Graphics gra = Graphics.FromImage(bmp);
            gra.DrawImage(m_Image, 0, 0, w, h);
            gra.Dispose();

            int movr = 0, movd = 0;
            
            for (int k = 0; k < m_SizeMap * m_SizeMap; k++)
            {
               
                Bitmap img= new Bitmap(w / m_SizeMap, h / m_SizeMap);
                

                for (int i = 0; i < w / m_SizeMap; i++)
                    for (int j = 0; j < h / m_SizeMap; j++)
                        img.SetPixel(i, j, bmp.GetPixel(i + movr, j + movd));
                m_ImageList.Add(img);

                movr += w / m_SizeMap;
                if (movr == w)
                {
                    movr = 0;
                    movd += h / m_SizeMap;
                }
            }

        }
        public void Createbutton()
        {
            m_ButtonList.Clear();
            int top = 0;
            int count = 0;
            for (int i = 0; i < m_SizeMap; i++)
            {
                int left = 0;
                for (int j = 0; j < m_SizeMap; j++)
                {
                   
                    Button btn = new Button();
                    btn.Name = string.Format("", i, j);
                    btn.Size = new Size(360 / m_SizeMap, 360 / m_SizeMap);
                    btn.TabIndex = count;
					btn.Text = count.ToString();
					btn.TextAlign = ContentAlignment.TopLeft;
					btn.Top = top;
                    btn.Left = left;
                    left += 360 / m_SizeMap;
                    count++;
                    m_ButtonList.Add(btn);

                }
                top += 360 / m_SizeMap;
            }
        }


        public void setImage(Image img)
        {
            m_Image = img;
        }
        public void setSize(int size)
        {
            m_SizeMap = size;
        }

        public int getSize()
        {
            return m_SizeMap;
        }

        public ArrayList getButton()
        {
            return m_ButtonList;
        }

        public ArrayList getImages()
        {
            return m_ImageList;
        }

    }
}
