using Library.Entities;
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

namespace Library.Pages.PageTeacher.PagesTeachers.Pages
{
    /// <summary>
    /// Логика взаимодействия для MyClassesPage.xaml
    /// </summary>
    public partial class MyClassesPage : Page
    {

        public static int IdSchoolBooy { get; set; }

        public MyClassesPage()
        {
            InitializeComponent();
            ListDate();
            
            listMyClasses.Focus();
            AddHandler(KeyDownEvent, (KeyEventHandler)btnAppdate_KeyDown, true);            
        }

        private void listBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {           
            try
            {               
                if (listMyClasses.SelectedItem != null)
                {
                    IdSchoolBooy = (int)(listMyClasses.SelectedItem as Users).IdSchool;
                    borderImageBook.DataContext = App.DataBase.SchoolBoy.Where(p => p.Id == IdSchoolBooy).ToList();                   
                }
            }
            catch
            {
                MessagesInfo.ErrorServer();
            }
        }

        /// <summary>
        /// Заполняет данными ListView
        /// </summary>
        public void ListDate()
        {
            listMyClasses.ItemsSource = App.DataBase.Users.Where(p=>  p.SchoolBoy.IdClasses.ToString() == DateUser.IdClasses)
                .OrderBy(p=> p.SchoolBoy.SurName).ToList();
        }

        /// <summary>
        /// Обновляет данные
        /// </summary>
        private void LoadData()
        {
            App.DataBase.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            ListDate();
            
        }

        /// <summary>
        /// Кнопка обновления данных 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAppdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                LoadData();
            }
        }

        /// <summary>
        /// Поиск данных
        /// </summary>
        public void PoiskDate()
        {
            if (!string.IsNullOrEmpty(tbPoisk.Text))
            {
                try
                {
                    listMyClasses.ItemsSource = App.DataBase.Users.Where(p => (p.SchoolBoy.IdClasses.ToString() == DateUser.IdClasses) &&

                    (p.SchoolBoy.Name.ToString().ToLower().Contains(tbPoisk.Text.ToLower()) ||
                    p.SchoolBoy.SurName.ToString().ToLower().Contains(tbPoisk.Text.ToLower()) ||
                    p.SchoolBoy.Address.ToString().ToLower().Contains(tbPoisk.Text.ToLower()) ||

                    p.Login.ToString().ToLower().Contains(tbPoisk.Text.ToLower()) ||
                    p.Password.ToString().ToLower().Contains(tbPoisk.Text.ToLower()) ||


                    p.SchoolBoy.Telephone.ToString().ToLower().Contains(tbPoisk.Text.ToLower())))
                    .OrderBy(p =>p.SchoolBoy.SurName).ToList();

                    var rows = listMyClasses.ItemsSource.Cast<Users>().ToList();
                    if (rows.Count == 0)
                    {
                        tbInfo.Visibility = Visibility.Visible;
                    }
                    if (rows.Count != 0)
                    {
                        tbInfo.Visibility = Visibility.Collapsed;
                    }
                }
                catch
                {
                    tbInfo.Visibility = Visibility.Collapsed;
                    MessageBox.Show("Ошибка в получении данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                try
                {
                    tbInfo.Visibility = Visibility.Collapsed;
                    ListDate();
                }
                catch
                {
                    tbInfo.Visibility = Visibility.Collapsed;
                    MessageBox.Show("Ошибка в получении данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        /// <summary>
        /// Если текстовое поле пустое, то возвращаются все данные в сходное положение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPoisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPoisk.Text == "")
            {
                ListDate();
                tbInfo.Visibility = Visibility.Collapsed;
            }            
        }


        /// <summary>
        /// Кнопка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPoisk_Click(object sender, RoutedEventArgs e) => PoiskDate();
       
        /// <summary>
        /// Прокручивает ползунок, даже если мышка не наведена на него
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e) => ScrollWiewers.ScrollWiewerContentScroll(sender, e);
      
        /// <summary>
        /// Открывает изображение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageBook_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            borderImageBook.Visibility = Visibility.Visible;
            btnPoisk.IsEnabled = false;
        }


        /// <summary>
        /// Кнопка редактирования учеников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditUser_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.ApdateCheck = "1";
            NavigationManager.StartFrame.Navigate(new EditMyCkassesPage((sender as Button).DataContext as Users));
        }

        /// <summary>
        /// Страница выдачи класса 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVidasha_Click(object sender, RoutedEventArgs e) => NavigationManager.StartFrame.Navigate(new VidahaMyClassesPage());
       
        /// <summary>
        /// Скрывает отображенную картинку 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorder_Click(object sender, RoutedEventArgs e)
        {
            borderImageBook.Visibility = Visibility.Collapsed;
            btnPoisk.IsEnabled = true;
        }



        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(NavigationManager.ApdateCheck == "3")
            {
                LoadData();               
            }
        }

        /// <summary>
        /// Кнопка добавить учеников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdSchoolBoy_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.ApdateCheck = "2";
            NavigationManager.StartFrame.Navigate(new EditMyCkassesPage(null));
        }
    }
}
