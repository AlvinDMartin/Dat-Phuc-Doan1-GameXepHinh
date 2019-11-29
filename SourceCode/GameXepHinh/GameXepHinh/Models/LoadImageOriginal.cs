using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameXepHinh.Models
{
    public class LoadImageOriginal
    {
        List<string> ListImage = new List<string>() { "anime", "anime 2", "anime 3" };

        public List<string> getImageOriginal()
        {
           return ListImage;
        }
    }
}
