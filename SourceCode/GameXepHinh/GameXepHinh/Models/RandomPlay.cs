using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameXepHinh.Models
{
    public partial class RandomPlay
    {
        int ktra = 0;
        int count = 1;

        int gan = 1;                        // tránh trường hợp random lại số cũ
        Button gan2 = new Button();         //tránh trường hợp swap lại vị trí cũ

        Random rand = new Random();

        MovePlay _MovePlay = new MovePlay();
        LoadSize _size = new LoadSize();
        Button[] arr4Vitri = new Button[5];

        public void ran( Button emply , Button full, LoadSize getsize)
        {
            _size = getsize;
            int s = _size.getSize() * _size.getSize();

            if(emply == full)
            {
                return;
            }
            else if (_MovePlay.UP(emply, full, _size) == true)
            {
                mang(full);
            }
            else if (_MovePlay.DOWN(emply, full, _size) == true)
            {
                mang(full);
            }
            else if (_MovePlay.LEFT(emply, full, _size) == true)
            {
                mang(full);
            }
            else if (_MovePlay.RIGHT(emply, full, _size) == true)
            {
                mang(full);
            }
            
        }
        public void SwapRan(Button emp)
        {
            do
            {
                ktra = rand.Next(1, count); 
                
            } while (gan == ktra && gan2 == arr4Vitri[ktra]);

            gan = ktra;
            gan2 = arr4Vitri[ktra];

            if (arr4Vitri[ktra] == emp)
            {
                return;
            }
            else
            {
                _MovePlay.swap(arr4Vitri[ktra], emp);

                //làm sạch hàm lưu trữ tạm thời
                count = 1;
                for (int x = 0; x < 5; x++)
                {
                    arr4Vitri[x] = null;
                }
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
            
        }
        public void mang(Button a)
        {
            arr4Vitri[count] = a;
            count++;
        }
    }
}
