using Library.Logic;
using Library.Pages.PageLibrarian.Pages;
using Library.Pages.PageStudent.Pages;
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


namespace Library.Pages.PageLibrarian
{
    /// <summary>
    /// Логика взаимодействия для MainPageLibrarian.xaml
    /// </summary>
    public partial class MainPageLibrarian : Page
    {
        public MainPageLibrarian()
        {
            InitializeComponent();
        }

        private void btnUserLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.ApdateCheck = "0";
            NavigationManager.StartFrame.Navigate(new UserPage());
        }

       

        private void btnBooks_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.ApdateCheck = "0";
            NavigationManager.StartFrame.Navigate(new BookPage());
        }

        private void btnPostovhik_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.ApdateCheck = "0";
            NavigationManager.StartFrame.Navigate(new SuppliersPage());
        }

        private void btnVidahaShool_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.ApdateCheck = "0";
            NavigationManager.StartFrame.Navigate(new ExtraditionPage());
        }
    }
}
