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
    public partial class LoadSize
    {
        int m_SizeMap = 3;
        public void setSize(int sizenew)
        {
            m_SizeMap = sizenew;
        }
        public int getSize()
        {
            return m_SizeMap;
        }

    }
}
