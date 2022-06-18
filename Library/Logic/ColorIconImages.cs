using FontAwesome.Sharp;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Library.Logic
{
    public class ColorIconImages
    {
        /// <summary>
        /// Меняет цвет иконок
        /// </summary>
        public static void ForegroundIcon(IconImage icon1, IconImage icon2, IconImage icon3, IconImage icon4,
            IconImage icon5, IconImage icon6, IconImage icon7, IconImage icon8, int color)
        {
            if (color == 0)
            {
                icon1.Foreground = Brushes.Gray;
            }

            if (color == 1)
            {
                icon1.Foreground = Brushes.Blue;
            }
            
           
            if (icon2 != null)
            {
                icon2.Foreground = Brushes.Gray;
            }

            if (icon3 != null)
            {
                icon3.Foreground = Brushes.Gray;
            }

            if (icon4 != null)
            {
                icon4.Foreground = Brushes.Gray;
            }
            if (icon5 != null)
            {
                icon5.Foreground = Brushes.Gray;
            }

            if (icon6 != null)
            {
                icon6.Foreground = Brushes.Gray;
            }
            if (icon7 != null)
            {
                icon7.Foreground = Brushes.Gray;
            }
            if (icon8 != null)
            {
                icon8.Foreground = Brushes.Gray;
            }
        }   
               
    }
}
