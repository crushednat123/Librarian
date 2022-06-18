using Library.Logic;
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

namespace Library.Pages.PageTeacher
{
    /// <summary>
    /// Логика взаимодействия для MainPagesTechers.xaml
    /// </summary>
    public partial class MainPagesTechers : Page
    {
        public MainPagesTechers()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Страница книг
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBooks_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new BookPage());
            NavigationManager.ApdateCheck = "0";
        }

        /// <summary>
        /// Страница мои книги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBookMe_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new PagesTeachers.Pages.MyBookPage());
            NavigationManager.ApdateCheck = "0";
        }


        
        /// <summary>
        /// Страница мои книги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyClasses_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new PagesTeachers.Pages.MyClassesPage());
            NavigationManager.ApdateCheck = "0";
        }
    }
}
