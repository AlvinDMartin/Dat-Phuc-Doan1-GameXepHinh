using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameXepHinh.Models
{
    public partial class LoadButton
    {
        ArrayList m_ButtonList = new ArrayList();
        LoadSize _Loadsize = new LoadSize();

        public void Createbutton(LoadSize getsize)
        {
            _Loadsize = getsize;
            m_ButtonList.Clear();
            int top = 0;
            int count = 0;
            for (int i = 0; i < _Loadsize.getSize(); i++)
            {
                int left = 0;
                for (int j = 0; j < _Loadsize.getSize(); j++)
                {
                    Button btn = new Button();
                    btn.Name = string.Format(count.ToString(), i, j);
                    btn.Size = new Size(360 / _Loadsize.getSize(), 360 / _Loadsize.getSize());
                    btn.TabIndex = count;
                    btn.Text = count.ToString();
                    btn.TextAlign = ContentAlignment.TopLeft;
                    btn.Top = top;
                    btn.Left = left;
                    left += 360 / _Loadsize.getSize();
                    count++;
                    m_ButtonList.Add(btn);
                }
                top += 360 / _Loadsize.getSize();
            }
        }
        public ArrayList getButton()
        {
            return m_ButtonList;
        }
    }
}
