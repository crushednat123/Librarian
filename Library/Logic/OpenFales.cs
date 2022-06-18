using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Library.Logic
{
    public class OpenFales
    {
        /// <summary>
        /// Позволяет записать путь файла в текст бокс
        /// </summary>
        /// <param name="textBox"></param>
        public static void FalesOpenFale(TextBox textBox, string filter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = filter;

            if (openFileDialog.ShowDialog() == true)
            {
                textBox.Text = openFileDialog.FileName;
            }
        }

    }
}
