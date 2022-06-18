using Library.Entities;
using Library.Logic;
using Library.Pages.PageLibrarian.Pages.EditingPages;
using Library.Pages.PagePrint;
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
    /// Логика взаимодействия для ExtraditionPage.xaml
    /// </summary>
    public partial class ExtraditionPage : Page
    {
        public static int IdBookExtra { get; set; }
        public static int IdDeleteBookExtra = -1;
        public static byte typeLocation = 0;

        public ExtraditionPage()
        {
            InitializeComponent();
            cbChekDate.SelectedIndex = 0;
            ListDate();
            listExtradition.Focus();
            AddHandler(KeyDownEvent, (KeyEventHandler)btnApdate_KeyDown, true);
        }


        /// <summary>
        /// Меняет данные, в зависимости какой Item выбран 
        /// </summary>
        public void ListDate()
        {           
      
            if (cbChekDate.SelectedIndex == 0)
            {
                listExtradition.ItemsSource = App.DataBase.Extraditions.ToArray();
                InfoElseNull();
            }

            if (cbChekDate.SelectedIndex == 1)
            {
                listExtradition.ItemsSource = App.DataBase.Extraditions.Where(p=> p.IdSchoolBoy !=null).ToArray();
                InfoElseNull();
            }

            if (cbChekDate.SelectedIndex == 2)
            {
                listExtradition.ItemsSource = App.DataBase.Extraditions.Where(p=> p.IdTeachers != null).ToArray();
                InfoElseNull();
            }

        }


        /// <summary>
        /// Если данных нет в лист вью
        /// </summary>
        public void InfoElseNull()
        {
            var rows = listExtradition.ItemsSource.Cast<Extraditions>().ToList();
            if (rows.Count == 0)
            {               
                tbInfo.Visibility = Visibility.Visible;
            }
            if (rows.Count != 0)
            {              
                tbInfo.Visibility = Visibility.Collapsed;
            }
        }



        /// <summary>
        /// Кнопка добавления выдачи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdExtadition_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new EditOutputPage(null));
            NavigationManager.ApdateCheck = "0";

            NavigationManager.TypeBattun = 0;
        }


        /// <summary>
        /// Кнопка удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteExtradition_Click(object sender, RoutedEventArgs e)
        {
           MessageBoxResult mesBoxRes = MessageBox.Show("Вы точно хотите удалить эту книгу?", "Внимание",
           MessageBoxButton.YesNo,
           MessageBoxImage.Question);
            if (mesBoxRes == MessageBoxResult.Yes)
            {
                btnApdate.IsEnabled = false;
                btnDeleteExtradition.IsEnabled = false;
                btnAdExtadition.IsEnabled = false;
                borderTypeBook.Visibility = Visibility.Visible;
                btnPoisk.IsEnabled = false;
                cbChekDate.IsEnabled = false;                
            }
        }


        /// <summary>
        /// Данные по умолчанию если, в строке не введены символы
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
        /// Поиск происходит за счёт выбранного элемента в выподающем списке
        /// </summary>
        /// <param name="param"></param>
        public void Search(byte param)
        {
            if (param == 1)
            {
                listExtradition.ItemsSource = App.DataBase.Extraditions.ToList().Where(p => 
                    (p.Books.NameBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.Books.NamberBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.Books.AuthorOfThebook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||                  
                    p.EndDate.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.DateOfISsue.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.Books.YearOfPublication.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()))).ToList();

                InfoElseNull();
            }

            
            if (param == 2)
            {
                listExtradition.ItemsSource = App.DataBase.Extraditions.ToList().Where(p => (p.IdSchoolBoy != null) &&
                     (p.Books.NameBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                     p.Books.NamberBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                     p.Books.AuthorOfThebook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                     p.SchoolBoy.Name.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                     p.SchoolBoy.SurName.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                     p.EndDate.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                     p.DateOfISsue.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                     p.Books.YearOfPublication.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()))).ToList();

                InfoElseNull();

            }

            if (param == 3)
            {
                listExtradition.ItemsSource = App.DataBase.Extraditions.ToList().Where(p => (p.IdTeachers != null) &&
                    (p.Books.NameBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.Books.NamberBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.Books.AuthorOfThebook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.EndDate.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.DateOfISsue.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.Teachers.Name.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.Teachers.SurName.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.Books.YearOfPublication.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()))).ToList();

                InfoElseNull();
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
                    if (cbChekDate.SelectedIndex == 0)
                    {
                        Search(1);
                    }

                    if (cbChekDate.SelectedIndex == 1)
                    {
                        Search(2);
                    }

                    if (cbChekDate.SelectedIndex == 2)
                    {
                        Search(3);
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


        private void cbChekDate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbChekDate.SelectedIndex == 0)
            {
                listExtradition.ItemsSource = App.DataBase.Extraditions.ToList();
            }

            if (cbChekDate.SelectedIndex == 1)
            {
                listExtradition.ItemsSource = App.DataBase.Extraditions.Where(p=> p.IdSchoolBoy != null).ToList();
            }

            if (cbChekDate.SelectedIndex == 2)
            {
                listExtradition.ItemsSource = App.DataBase.Extraditions.Where(p => p.IdTeachers != null).ToList();
            }            
        }



        /// <summary>
        /// Обновляет данные
        /// </summary>
        private void LoadData()
        {
            App.DataBase.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            ListDate();
            cbChekDate.SelectedIndex = 0;
        }

        /// <summary>
        /// Срабатывает при нажатии F5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                LoadData();
            }
        }


        /// <summary>
        /// Кнопка обновления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApdate_Click(object sender, RoutedEventArgs e) => LoadData();


        /// <summary>
        /// Заставляет прокручивать содержимое, вне зависимости наведена ли мышка на прокрутку или нет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e) => ScrollWiewers.ScrollWiewerContentScroll(sender, e);



        /// <summary>
        /// Кнопка редактирование выдачи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditExtradition_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new EditOutputPage((sender as Button).DataContext as Extraditions));
            NavigationManager.ApdateCheck = "0";

            NavigationManager.TypeBattun = 1;
        }


        /// <summary>
        /// Скрывает отображенную картинку 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorder_Click(object sender, RoutedEventArgs e)
        {
            btnApdate.IsEnabled = true;
            btnDeleteExtradition.IsEnabled = true;
            btnAdExtadition.IsEnabled = true;
            borderImageBook.Visibility = Visibility.Collapsed;
            btnPoisk.IsEnabled = true;
            cbChekDate.IsEnabled = true;
        }


        /// <summary>
        /// Открывает изображение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            btnApdate.IsEnabled = false;
            btnDeleteExtradition.IsEnabled = false;
            btnAdExtadition.IsEnabled = false;
            borderImageBook.Visibility = Visibility.Visible;
            btnPoisk.IsEnabled = false;
            cbChekDate.IsEnabled = false;
        }




        /// <summary>
        /// Получает айдишник книги, и выводит картинку этой книги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listExtradition_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (IdBookExtra == IdDeleteBookExtra)
                {
                    IdBookExtra = 0;
                }

                else
                {
                    if(listExtradition.SelectedItem != null)
                    {
                        IdBookExtra = (int)(listExtradition.SelectedItem as Extraditions).IdBook;

                        IdDeleteBookExtra = -1;

                        borderImageBook.DataContext = App.DataBase.Books.Where(p => p.Id == IdBookExtra).ToList();

                    }
                }
            }

            catch 
            {
                MessagesInfo.ErrorServer();
            }
        }


        /// <summary>
        /// Кнопка печати
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, RoutedEventArgs e) => NavigationManager.StartFrame.Navigate(new VidachaAllBookPrint());


        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (NavigationManager.ApdateCheck == "1")
            {
                LoadData();
                NavigationManager.ApdateCheck = "0";
            }
        }




        /// <summary>
        /// Скрывает выбор местоположении книги 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnСancel_Click(object sender, RoutedEventArgs e) => BorderColapsed();


        /// <summary>
        /// Скрывает бордер 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BorderColapsed()
        {
            btnApdate.IsEnabled = true;
            btnDeleteExtradition.IsEnabled = true;
            btnAdExtadition.IsEnabled = true;
            borderTypeBook.Visibility = Visibility.Collapsed;
            btnPoisk.IsEnabled = true;
            cbChekDate.IsEnabled = true;
        }


        private void btnLiabrarian_Click(object sender, RoutedEventArgs e)
        {
            typeLocation = 1;
            DeleteBook(typeLocation);
        }

        private void btnReadingRoom_Click(object sender, RoutedEventArgs e)
        {
            typeLocation = 2;
            DeleteBook(typeLocation);
        }

        /// <summary>
        /// Удаление выданной книги
        /// </summary>
        public void DeleteBook(byte location)
        {
            try
            {
                IdDeleteBookExtra = (int)(listExtradition.SelectedItem as Extraditions).IdBook;
                App.DataBase.Extraditions.Remove(listExtradition.SelectedItem as Extraditions);
                var sqlBook = $"Update Books Set IdBookLocation = {location} Where Id = {IdBookExtra}";
                var update = App.DataBase.Database.ExecuteSqlCommand(sqlBook);
                App.DataBase.SaveChanges();               
                MessageBox.Show("Данные удалены!", "", MessageBoxButton.OK, MessageBoxImage.Information);
                BorderColapsed();
                App.DataBase.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                ListDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Страница истории выдачи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistory_Click(object sender, RoutedEventArgs e) => NavigationManager.StartFrame.Navigate(new HistoryIssuePage());

    }
}
