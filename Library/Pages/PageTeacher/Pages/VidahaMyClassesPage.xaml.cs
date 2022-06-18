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
using Library.Entities;
using Library.Logic;

namespace Library.Pages.PageTeacher.PagesTeachers.Pages
{
    /// <summary>
    /// Логика взаимодействия для VidahaMyClassesPage.xaml
    /// </summary>
    public partial class VidahaMyClassesPage : Page
    {
        public static int IdBook { get; set; }
        public VidahaMyClassesPage()
        {
            InitializeComponent();
            ListDate();

            listBook.Focus();
            AddHandler(KeyDownEvent, (KeyEventHandler)btnAppdate_KeyDown, true);
        }


        public void ListDate()
        {
            listBook.ItemsSource = App.DataBase.Extraditions.Where(p => p.IdSchoolBoy != null && p.IdClasses.ToString() 
            == DateUser.IdClasses && p.IdTypeOfHalls == 3).ToList();
        }


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
        /// Заполняет переменную айдишником книги, что в дальнейшем позволяет открыть картинку 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (listBook.SelectedItem != null)
                {
                    IdBook = (int)(listBook.SelectedItem as Extraditions).IdBook;
                    borderImageBook.DataContext = App.DataBase.Books.Where(p => p.Id == IdBook).ToList();
                }
            }

            catch
            {
                MessagesInfo.ErrorServer();
            }
        }


        /// <summary>
        /// Заставляет прокручивать содержимое, вне зависимости наведена ли мышка на прокрутку или нет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e) => ScrollWiewers.ScrollWiewerContentScroll(sender, e);
       
        /// <summary>
        /// Если текстовое поле пустое, то возвращаются все данные в сходное положение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDafaultDate_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbDafaultDate.Text == "")
            {
                ListDate();
                tbInfo.Visibility = Visibility.Collapsed;
            }           
        }

        /// <summary>
        /// Если текущий индекс у текст бокса равен такому значение, то поиск будет идти исключительно
        /// по такому индексу у комбо бокса
        /// </summary>
        public void TextPoisck()
        {
            if (!string.IsNullOrEmpty(tbDafaultDate.Text))
            {
                try
                {
                    listBook.ItemsSource = App.DataBase.Extraditions.ToList().Where(p => ((p.IdClasses.ToString() == DateUser.IdClasses) && p.IdSchoolBoy != null) &&
                           (p.Books.NameBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                           p.Books.NamberBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                           p.Books.AuthorOfThebook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                           p.SchoolBoy.Name.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                           p.SchoolBoy.SurName.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                           p.Books.YearOfPublication.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()))).ToList();


                    var rows = listBook.ItemsSource.Cast<Extraditions>().ToList();
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
        /// Кнопка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPoisk_Click(object sender, RoutedEventArgs e) => TextPoisck();
       
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
    }
}
