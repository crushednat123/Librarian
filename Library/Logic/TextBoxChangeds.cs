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
    public class TextBoxChangeds
    {
        public static void TextLoginChanged(TextBox textBox, TextBlock textBlock, TextBlock textBlock1)
        {
            if (textBox.Text.Length == 0)
                textBlock.Visibility = Visibility.Visible;

            else if (textBox.Text.Length != 0)
                textBlock.Visibility = Visibility.Collapsed;

            textBlock1.Text = textBox.Text.Length.ToString(CultureInfo.InvariantCulture);
        }

    }
}
