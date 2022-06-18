using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Library.Logic
{
    public class PasswordChangeds
    {
        public static void TextPasswordCheck(PasswordBox password, TextBlock textBlock1, TextBlock textBlock2, CheckBox checkBox)
        {
            if (password.Password.Length == 0)
            {
                checkBox.IsEnabled = false;
                textBlock1.Visibility = Visibility.Visible;
                textBlock2.Text = "0";
            }
            if (password.Password.Length != 0)
            {
                checkBox.IsEnabled = true;

                textBlock1.Visibility = Visibility.Collapsed;

                textBlock2.Text = password.Password.Length.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}
