using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Library.Logic
{
   public class TextColors
   {
        public static void ElementColor(TextBlock textBlock1, TextBlock textBlock2)
        {
            if (textBlock1.Text == "50")
            {
                textBlock1.Foreground = System.Windows.Media.Brushes.Red;
                textBlock2.Foreground = System.Windows.Media.Brushes.Red;
            }
            else if (textBlock1.Text != "50")
            {
                textBlock1.Foreground = System.Windows.Media.Brushes.Black;
                textBlock2.Foreground = System.Windows.Media.Brushes.Black;
            }

        }       
   }
}
