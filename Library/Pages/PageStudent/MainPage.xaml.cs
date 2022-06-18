using Library.Logic;
using Library.Pages.PageStudent.Pages;
using Library.Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Library.Pages.PageStudent
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

                   
        private void btnBooks_Click(object sender, RoutedEventArgs e)
        {          
            NavigationManager.StartFrame.Navigate(new BookPage());
            NavigationManager.ApdateCheck = "0";
        }

        private void btnBookMe_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new PageStudent.Pages.MyBookPage());
            NavigationManager.ApdateCheck = "0";
        }
    }
}

