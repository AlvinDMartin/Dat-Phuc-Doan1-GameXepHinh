using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameXepHinh.Models
{
    public partial class LoadCropImage
    {
        ArrayList m_ImageList = new ArrayList();
        LoadSize _Size = new LoadSize();
        Image m_Image;

        public void cropImageTomages(int w, int h, LoadSize getsize)
        {
            _Size = getsize;
            m_ImageList.Clear();
            Bitmap bmp = new Bitmap(w, h);
            Graphics gra = Graphics.FromImage(bmp);
            gra.DrawImage(m_Image, 0, 0, w, h);
            gra.Dispose();

            int movr = 0, movd = 0;

            for (int k = 0; k < _Size.getSize() * _Size.getSize(); k++)
            {

                Bitmap img = new Bitmap(w / _Size.getSize(), h / _Size.getSize());


                for (int i = 0; i < w / _Size.getSize(); i++)
                    for (int j = 0; j < h / _Size.getSize(); j++)
                    {
                        img.SetPixel(i, j, bmp.GetPixel(i + movr, j + movd));
                    }


                m_ImageList.Add(img);

                movr += w / _Size.getSize();
                if (movr == w)
                {
                    movr = 0;
                    movd += h / _Size.getSize();
                }
            }

        }
        public void setImage(Image img)
        {
            m_Image = img;
        }
        public ArrayList getImages()
        {
            return m_ImageList;
        }

    }
}
