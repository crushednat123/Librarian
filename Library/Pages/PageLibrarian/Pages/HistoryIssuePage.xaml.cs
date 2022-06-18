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

namespace Library.Pages.PageLibrarian.Pages
{
    /// <summary>
    /// Логика взаимодействия для HistoryIssuePage.xaml
    /// </summary>
    public partial class HistoryIssuePage : Page
    {
        public HistoryIssuePage()
        {
            InitializeComponent();
            cmTypeUsers.SelectedIndex = 0;
            ListDate();
        }

        /// <summary>
        /// подсчёт количество строк 
        /// </summary>
        public void InfoElseNull()
        {
            var rows = listBook.ItemsSource.Cast<HistoriExtradition>().ToList();
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
        /// Загружает данные в лист вью
        /// </summary>
        public void ListDate()
        {
            if (cmTypeUsers.SelectedIndex == 0)
            {
                listBook.ItemsSource = App.DataBase.HistoriExtradition.ToArray();
            }

            if (cmTypeUsers.SelectedIndex == 1)
            {
                listBook.ItemsSource = App.DataBase.HistoriExtradition.Where(p=> p.TypeUsers == 1).ToArray();
            }

            if (cmTypeUsers.SelectedIndex == 2)
            {
                listBook.ItemsSource = App.DataBase.HistoriExtradition.Where(p => p.TypeUsers == 2).ToArray();
            }

        }
        
        /// <summary>
        /// Что бы не дублировать поля ...
        /// </summary>
        /// <param name="param"></param>
        public void TypePoisk(byte typeUsers)
        {          
            // если список содержит ВСЕ
            if(typeUsers == 0)
            {
                // не включает класс, дату выдачи, дату окончания выдачи
                if (cbCheck.IsChecked == true)
                {
                    listBook.ItemsSource = App.DataBase.HistoriExtradition.Where(p =>
                        p.Book.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.Users.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.NamberBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower())).ToList();
                }

                // включает все поля
                if (cbCheck.IsChecked == false)
                {
                    listBook.ItemsSource = App.DataBase.HistoriExtradition.Where(p =>
                        p.Book.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.Users.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.DateOfISsue.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.EndDate.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.Class.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.NamberBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower())).ToList();
                }
                InfoElseNull();
            }

            // если список содержит конкретных пользователей
            if (typeUsers != 0)
            {
                // не включает класс, дату выдачи, дату окончания выдачи
                if (cbCheck.IsChecked == true)
                {
                    listBook.ItemsSource = App.DataBase.HistoriExtradition.Where(p => (p.TypeUsers == typeUsers) &&
                       (p.Book.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.Users.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.NamberBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()))).ToList();
                }

                // включает все поля
                if (cbCheck.IsChecked == false)
                {
                    listBook.ItemsSource = App.DataBase.HistoriExtradition.Where(p => (p.TypeUsers == typeUsers) &&
                        (p.Book.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.Users.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.DateOfISsue.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.EndDate.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.Class.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                        p.NamberBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()))).ToList();
                }
                InfoElseNull();
            }


        }

        /// <summary>
        /// Поиск 
        /// </summary>
        public void TextPoisck()
        {
            if (!string.IsNullOrEmpty(tbDafaultDate.Text))
            {
                try
                {
                    if (cmTypeUsers.SelectedIndex == 0)
                    {
                        TypePoisk(0);
                    }

                    if (cmTypeUsers.SelectedIndex == 1)
                    {
                        TypePoisk(1);
                    }

                    if (cmTypeUsers.SelectedIndex == 2)
                    {
                        TypePoisk(2);
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
        /// Выводит все данные по умолчанию
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
        /// Фильтрует данные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmTypeUsers_SelectionChanged(object sender, SelectionChangedEventArgs e) => ListDate();



        /// <summary>
        /// Заставляет прокручивать содержимое, вне зависимости наведена ли мышка на прокрутку или нет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e) => ScrollWiewers.ScrollWiewerContentScroll(sender, e);



        /// <summary>
        /// кнопка удаление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteHistory_Click(object sender, RoutedEventArgs e)
        {
           MessageBoxResult mesBoxRes = MessageBox.Show("Вы точно хотите удалить эту запись?", "Внимание",
           MessageBoxButton.YesNo,
           MessageBoxImage.Question);
           if (mesBoxRes == MessageBoxResult.Yes)
           {
                try
                {
                    App.DataBase.HistoriExtradition.Remove(listBook.SelectedItem as HistoriExtradition);
                    App.DataBase.SaveChanges();
                    MessageBox.Show("Данные удалены!", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    ListDate();
                }
                catch
                {
                    MessagesInfo.ErrorServer();
                }                
           }
        }
    }
}
