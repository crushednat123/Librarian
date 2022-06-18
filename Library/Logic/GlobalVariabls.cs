using FontAwesome.Sharp;
using Library.Pages.PageLibrarian.Pages;
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
    public class GlobalVariabls
    {
        // Книги
        public static string countIdNot3 { get; set; }
        public static string countBook { get; set; }

        // Пользователи
        public static byte UserType { get; set; }

        public static int shool = 1;
        public static int techers = 1;
        
        public static int countRow = 10;     
    }
}
