using Library.Logic;
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

namespace Library.Pages.PageLibrarian.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка учителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTeachers_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariabls.UserType = 3;

            NavigationManager.StartFrame.Navigate(new UserDatePage());            
        }

        /// <summary>
        /// Кнопка школьники
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShoolBooy_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariabls.UserType = 4;
            NavigationManager.StartFrame.Navigate(new UserDatePage());           
        }

        /// <summary>
        /// Кнопка библиотекари
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLibrarian_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariabls.UserType = 2;
            NavigationManager.StartFrame.Navigate(new UserDatePage());          
        }        
    }
}
