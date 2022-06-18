using Library.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Entities;
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
using Library.Pages.PageTeacher.PagesTeachers.Pages.Document;

namespace Library.Pages.PageTeacher.PagesTeachers.Pages
{
    /// <summary>
    /// Логика взаимодействия для MyBookPage.xaml
    /// </summary>
    public partial class MyBookPage : Page
    {
        public static int IdBookTeacher { get; set; }
        public MyBookPage()
        {
            InitializeComponent();
            DateBook();

            listBook.Focus();
            AddHandler(KeyDownEvent, (KeyEventHandler)btnAppdate_KeyDown, true);
        }


        /// <summary>
        /// Заполняет данными ListView 
        /// </summary>
        public void DateBook()
        {

            var extraditionSchool = App.DataBase.Extraditions.Where(p =>

            p.IdTeachers.ToString() == DateUser.Id && p.IdTypeOfHalls == 3).
            OrderBy(p => p.Books.NameBook).ToList();
            listBook.ItemsSource = extraditionSchool;
        }

        /// <summary>
        /// Поиск данных
        /// </summary>
        public void TextPoisck()
        {
            if (!string.IsNullOrEmpty(tbPoisk.Text))
            {
                try
                {
                    listBook.ItemsSource = App.DataBase.Extraditions.ToList().Where(p =>
                    (p.IdTeachers.ToString() == DateUser.Id && p.IdTypeOfHalls == 3) &&

                    (p.Books.NameBook.ToString().ToLower().Contains(tbPoisk.Text.ToLower()) ||
                    p.Books.AuthorOfThebook.ToString().ToLower().Contains(tbPoisk.Text.ToLower()) ||
                    p.Books.YearOfPublication.ToString().ToLower().Contains(tbPoisk.Text.ToLower()))).ToList();

                    var rows = listBook.ItemsSource.Cast<Extraditions>().OrderBy(p => p.Books.NameBook).ToList();
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
                    DateBook();
                }
                catch
                {
                    tbInfo.Visibility = Visibility.Collapsed;
                    MessageBox.Show("Ошибка в получении данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        /// <summary>
        /// Прокручивает ползунок, даже если мышка не наведена на него
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e) => ScrollWiewers.ScrollWiewerContentScroll(sender, e);
       
        /// <summary>
        /// Открывает страницу с книгой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDocument_Click(object sender, RoutedEventArgs e) => NavigationManager.StartFrame.Navigate(new ElectronikDocymentPage((sender as Button).DataContext as Extraditions));
      
        /// <summary>
        /// Если текстовое поле пустое, возвращает данные в исходное положение 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPoisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPoisk.Text == "")
            {
                DateBook();
                tbInfo.Visibility = Visibility.Collapsed;
            }            
        }

        /// <summary>
        /// Кнопка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPoisk_Click(object sender, RoutedEventArgs e) => TextPoisck();
        
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

        private void listBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (listBook.SelectedItem != null)
                {
                    IdBookTeacher = (int)(listBook.SelectedItem as Extraditions).IdBook;
                    borderImageBook.DataContext = App.DataBase.Books.Where(p => p.Id == IdBookTeacher).ToList();
                }

            }
            catch
            {
                MessagesInfo.ErrorServer();
            }
        }


        /// <summary>
        /// Открывает изображение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            borderImageBook.Visibility = Visibility.Visible;
            btnPoisk.IsEnabled = false;
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
                App.DataBase.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DateBook();
            }
        }
    }
}
