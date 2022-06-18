using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Library.Logic
{
    public class ImageVisible
    {
        /// <summary>
        /// Скрывает и отображает картинку пользователя
        /// </summary>
        public static void VisibleImage(Button btnUpdate, Border borderImage, Button btnPoisk, Button btnDelete, Button btnAd, byte visible)
        {
            if (visible == 1)
            {
                btnUpdate.IsEnabled = false;
                borderImage.Visibility = Visibility.Visible;
                btnPoisk.IsEnabled = false;
                btnDelete.IsEnabled = false;
                btnAd.IsEnabled = false;
            }

            if (visible == 0)
            {
                btnUpdate.IsEnabled = true;
                borderImage.Visibility = Visibility.Collapsed;
                btnPoisk.IsEnabled = true;
                btnDelete.IsEnabled = true;
                btnAd.IsEnabled = true;
            }
        }
    }
}
