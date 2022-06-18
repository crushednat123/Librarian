using FontAwesome.Sharp;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Library.Logic
{
    public class ButtonStyles
    {
        public static void StyleButton(Button button1, Button button2, Button button3, 
            Button button4, Button button5, Button button6, int color)
        {
            if(color == 0)
            {
                button1.Style = (Style)button1.FindResource("btnMenu");

            }
            else if(color == 1)
            {
              button1.Style = (Style)button1.FindResource("btnMenuActive");
            }

            button2.Style = (Style)button2.FindResource("btnMenu");
                    
            if(button3 != null)
            {
                button3.Style = (Style)button3.FindResource("btnMenu");
            }
                                                         
            button4.Style = (Style)button4.FindResource("btnMenu");

            if(button5 != null)
            {
                button5.Style = (Style)button5.FindResource("btnMenu");
            }

            if (button6 != null)
            {
                button6.Style = (Style)button6.FindResource("btnMenu");
            }
        }

        /// <summary>
        /// Отключает кнопку
        /// </summary>
        public static void ButtunDafault(Button buttonMinys, IconImage iconMinys)
        {
            buttonMinys.IsEnabled = false;
            iconMinys.Foreground = Brushes.Gray;            
        }
    }
}
