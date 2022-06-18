using Library.Entities;
using Library.Logic;
using Library.Pages.PageTeacher.PagesTeachers.Pages;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
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

namespace Library.Pages.PageStudent.Pages
{
    /// <summary>
    /// Логика взаимодействия для BookPage.xaml
    /// </summary>
    public partial class BookPage : Page
    {
        public BookPage()
        {
            InitializeComponent();

            DateBook();

            var holName = App.DataBase.TypeOfHalls.Where(p => p.Id < 3).ToList();

            holName.Insert(0, new TypeOfHalls
            {
                NameZal = "Все книги"
            });

            var itemsBook = App.DataBase.Items.ToList();

            cmBook.ItemsSource = holName;
            cmBook.SelectedIndex = 0;

            listBook.Focus();
            AddHandler(KeyDownEvent, (KeyEventHandler)btnApdate_KeyDown, true);           
        }

        public static int IdBook { get; set; }
        public static int IdDeleteBook = -1;


        public void CountBook(string countNot3, string countMax) => tbCountBook.Text = "Записей: " + countNot3 + $" / {countMax}";


        public void Pererachet(string rows)
        {
            GlobalVariabls.countIdNot3 = rows.ToString();
            CountBook(GlobalVariabls.countIdNot3, GlobalVariabls.countBook);
        }


        public void InfoElseNull()
        {
            var rows = listBook.ItemsSource.Cast<Books>().ToList();
            if (rows.Count == 0)
            {
                Pererachet("0");
                tbInfo.Visibility = Visibility.Visible;
            }
            if (rows.Count != 0)
            {
                Pererachet(rows.Count.ToString());
                tbInfo.Visibility = Visibility.Collapsed;
            }
        }



        /// <summary>
        /// Заставляет прокручивать содержимое, вне зависимости наведена ли мышка на прокрутку или нет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e) => ScrollWiewers.ScrollWiewerContentScroll(sender, e);
       

        /// <summary>
        /// Обновляет данные
        /// </summary>
        private void LoadData()
        {
            App.DataBase.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DateBook();
            cmBook.SelectedIndex = 0;
        }

        /// <summary>
        /// Меняет данные, в зависимости какой Item выбран 
        /// </summary>
        public void DateBook()
        {
            GlobalVariabls.countIdNot3 = App.DataBase.Books.ToList().Where(p => p.IdBookLocation != 3).Count().ToString();
            GlobalVariabls.countBook = App.DataBase.Books.ToList().Where(p => p.IdBookLocation != 3).Count().ToString();

            if (cmBook.SelectedIndex == 1)
            {
                listBook.ItemsSource = App.DataBase.Books.Where(p => p.IdBookLocation == 1 || p.IdBookLocation == null).OrderBy(p=> p.NameBook).ToList();
                
                tbInfo.Visibility = Visibility.Collapsed;
                InfoElseNull();
            }

            if (cmBook.SelectedIndex == 0)
            {
                listBook.ItemsSource = App.DataBase.Books.Where(p => p.IdBookLocation != 3).OrderBy(p => p.NameBook).ToList();
               
                tbInfo.Visibility = Visibility.Collapsed;
                InfoElseNull();
            }

            if (cmBook.SelectedIndex == 2)
            {
                listBook.ItemsSource = App.DataBase.Books.Where(p => p.IdBookLocation == 2).OrderBy(p => p.NameBook).ToList();               
                tbInfo.Visibility = Visibility.Collapsed;
                InfoElseNull();
            }

            if (listBook.ItemsSource != null)
            {
                CountBook(GlobalVariabls.countIdNot3, GlobalVariabls.countBook);
            }           
        }


        /// <summary>
        /// param (если данный параметр = Null или "" то поиск будет искать и такие записи
        /// где p.IdBookLocation == null)
        /// 
        /// Id - это поиск исключительно по такому айдишнику который p.IdBookLocation принимает
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="param"></param>
        public void Search(int Id, string param)
        {
            
            // выводит все записи из таблицы Книги 
            if(Id == 3)
            {
                // поиск по названии, по номеру книги, автор книгу 
                if (cbCheck.Visibility == Visibility.Visible && cbCheck.IsChecked == true)
                {
                    listBook.ItemsSource = App.DataBase.Books.ToList().Where(p => (p.IdBookLocation != Id) &&
                   (p.NameBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                   p.NamberBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                   p.AuthorOfThebook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()))).ToList();
                  
                }
                // поиск по названии, по номеру книги, автор книгу, год издания
                if (cbCheck.Visibility == Visibility.Collapsed || (cbCheck.Visibility == Visibility.Visible && cbCheck.IsChecked == false))
                {
                    listBook.ItemsSource = App.DataBase.Books.ToList().Where(p => (p.IdBookLocation != Id) &&
                       (p.NameBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                       p.NamberBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                       p.AuthorOfThebook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                       p.YearOfPublication.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()))).ToList();

                }

                InfoElseNull();

            }

            // выводит записи по выбранному из списка
            else
            {

                if (cbCheck.Visibility == Visibility.Visible && cbCheck.IsChecked == true)
                {
                    // поиск по названии, по номеру книги, автор книгу 
                    listBook.ItemsSource = App.DataBase.Books.ToList().Where(p => (p.IdBookLocation == Id || p.IdBookLocation.ToString() == param) &&
                        (p.NameBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.NamberBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.AuthorOfThebook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()))).ToList();
                }

                // поиск по названии, по номеру книги, автор книгу, год издания
                if (cbCheck.Visibility == Visibility.Collapsed || (cbCheck.Visibility == Visibility.Visible && cbCheck.IsChecked == false))
                {
                    listBook.ItemsSource = App.DataBase.Books.ToList().Where(p => (p.IdBookLocation == Id || p.IdBookLocation.ToString() == param) &&
                            (p.NameBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                            p.NamberBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                            p.AuthorOfThebook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                            p.YearOfPublication.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()))).ToList();
                }

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
                    if (cmBook.SelectedIndex == 2)
                    {
                        Search(2,null);
                    }

                    if (cmBook.SelectedIndex == 0)
                    {
                        Search(3,null);
                    }

                    if (cmBook.SelectedIndex == 1)
                    {
                        Search(1,"");
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
        /// Кнопка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPoisk_Click(object sender, RoutedEventArgs e) => TextPoisck();
      


        /// <summary>
        /// Если текстовое поле пустое, то возвращаются все данные в сходное положение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDafaultDate_TextChanged(object sender, TextChangedEventArgs e)
        {
          if(tbDafaultDate.Text == "")
          {
                DateBook();
                tbInfo.Visibility = Visibility.Collapsed;
          }        
        }

        /// <summary>
        /// Меняет данные у ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmBook_SelectionChanged(object sender, SelectionChangedEventArgs e) => DateBook();


        /// <summary>
        /// Кнопка обновления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApdate_Click(object sender, RoutedEventArgs e) => LoadData();
      

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
        /// Открывает электронный документ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBookDocument_Click(object sender, RoutedEventArgs e) => NavigationManager.StartFrame.Navigate(new DocumentBooksPage((sender as Button).DataContext as Books));
       

        private void btnEditBook_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new EditBookPage((sender as Button).DataContext as Books));
            
            
            NavigationManager.ApdateCheck = "0";

            NavigationManager.TextBoxIsRedonly = "1";
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new EditBookPage(null));          

           
            NavigationManager.ApdateCheck = "0";

            NavigationManager.TextBoxIsRedonly = "0";
        }


        /// <summary>
        /// Скрывает кнопку в зависимости какая роль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(NavigationManager.ApdateCheck == "1")
            {
                LoadData();
                NavigationManager.ApdateCheck = "0";
            }

            if (DateUser.IdRole == "2")
            {
                btnAddBook.Visibility = Visibility.Visible;
                btnDeleteBook.Visibility = Visibility.Visible;
                cbCheck.Visibility = Visibility.Visible;
            }
            if (DateUser.IdRole == "3")
            {
                btnAddBook.Visibility = Visibility.Collapsed;
                btnDeleteBook.Visibility = Visibility.Collapsed;
                cbCheck.Visibility = Visibility.Collapsed;
            }
            if (DateUser.IdRole == "4")
            {
                btnAddBook.Visibility = Visibility.Collapsed;
                btnDeleteBook.Visibility = Visibility.Collapsed;
                cbCheck.Visibility = Visibility.Collapsed;
            }             
        }



        /// <summary>
        /// Скрывает отображенную картинку 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorder_Click(object sender, RoutedEventArgs e)
        {
            borderImageBook.Visibility = Visibility.Collapsed;
            btnDeleteBook.IsEnabled = true;
            btnApdate.IsEnabled = true;
            btnPoisk.IsEnabled = true;
            btnAddBook.IsEnabled = true;
            cmBook.IsEnabled = true;
        }


        private void listBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (IdBook == IdDeleteBook)
                {
                    IdBook = 0;
                }

                else
                {
                    if(listBook.SelectedItem != null)
                    {
                        IdBook = (listBook.SelectedItem  as Books).Id;
                        IdDeleteBook = -1;
                        borderImageBook.DataContext = App.DataBase.Books.Where(p => p.Id == IdBook).ToList();                
                    }
                    
                }
            }

            catch
            {
                MessagesInfo.ErrorServer();
            }
        }

        /// <summary>
        /// Кнопка удаления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteBook_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult mesBoxRes = MessageBox.Show("Вы точно хотите удалить эту книгу?", "Внимание",
            MessageBoxButton.YesNo,
            MessageBoxImage.Question);
            if (mesBoxRes == MessageBoxResult.Yes)
            {
                try
                {
                    IdDeleteBook = (listBook.SelectedItem as Books).Id;                   
                    App.DataBase.Books.Remove(listBook.SelectedItem as Books);
                    App.DataBase.SaveChanges();
                    MessageBox.Show("Данные удалены!", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    DateBook();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            
        }


        /// <summary>
        /// Открывает изображение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageBook_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {           
            btnApdate.IsEnabled = false;
            btnDeleteBook.IsEnabled = false;
            btnAddBook.IsEnabled = false;
            borderImageBook.Visibility = Visibility.Visible;
            btnPoisk.IsEnabled = false;   
            cmBook.IsEnabled = false;
        }
    }
}
