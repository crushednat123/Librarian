using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FontAwesome.Sharp;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Library.Logic
{
    public class Expands
    {
        public static void ExpandsWindow(Window startWindow,
                                         IconImage iconExpand, Button btnExpand)
        {
            if (startWindow.WindowState == WindowState.Normal)
            {
                startWindow.WindowState = WindowState.Maximized;
                iconExpand.Icon = IconChar.WindowRestore;
                btnExpand.ToolTip = "Свернуть в окно";

            }

            else if (startWindow.WindowState == WindowState.Maximized)
            {
                startWindow.Width = 1300;                
                startWindow.WindowState = WindowState.Normal;
                iconExpand.Icon = IconChar.ExpandArrowsAlt;
                btnExpand.ToolTip = "Развернуть";

            }
        }
    }
}
