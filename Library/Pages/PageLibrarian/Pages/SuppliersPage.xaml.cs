using Library.Entities;
using Library.Logic;
using Library.Pages.PageLibrarian.Pages.EditingPages;
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
    /// Логика взаимодействия для SuppliersPage.xaml
    /// </summary>
    public partial class SuppliersPage : Page
    {
        public SuppliersPage()
        {
            InitializeComponent();
            ListDate();
            AddHandler(KeyDownEvent, (KeyEventHandler)btnApdate_KeyDown, true);
        }

        /// <summary>
        /// Выводит данные 
        /// </summary>
        public void ListDate()
        {
            listSuppliers.ItemsSource = App.DataBase.DeliveryServices.ToList();
            btnDeleteSuplier.Visibility = Visibility.Collapsed;
            cbChekDate.SelectedIndex = -1;
        }



        /// <summary>
        /// Полоса прокрутки у listView
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
            ListDate();
            cbChekDate.SelectedIndex = -1;
            btnDeleteSuplier.Visibility = Visibility.Collapsed;
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
        /// Если текущий индекс у текст бокса равен такому значение, то поиск будет идти исключительно
        /// по такому индексу у комбо бокса
        /// </summary>
        public void TextPoisck()
        {
            if (!string.IsNullOrEmpty(tbDafaultDate.Text))
            {
                try
                {
                  
                    listSuppliers.ItemsSource = App.DataBase.DeliveryServices.Where(p =>
                    p.SupplierName.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.Id.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.Telephone.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.Firm.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower())).ToArray();

                    var rows = listSuppliers.ItemsSource.Cast<DeliveryServices>().ToList();
                    if (rows.Count == 0)
                    {
                        tbInfo.Visibility = Visibility.Visible;
                    }
                    if (rows.Count != 0)
                    {
                        cbChekDate.SelectedIndex = -1;
                        btnDeleteSuplier.Visibility = Visibility.Collapsed;
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
        /// Отображает по умолчанию все данные
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



        private void btnDeleteSuplier_Click(object sender, RoutedEventArgs e)
        {
            var suplier = listSuppliers.SelectedItems.Cast<DeliveryServices>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {suplier.Count()} элементов ?",
                    "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    App.DataBase.DeliveryServices.Remove(listSuppliers.SelectedItem as DeliveryServices);
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



        /// <summary>
        /// Кнопка добавления поставщика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdSupplier_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new EditSupplierPage(null));
            NavigationManager.ApdateCheck = "0";

        }


        /// <summary>
        /// Кнопка редактирование поставщика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditSlupper_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new EditSupplierPage((sender as Button).DataContext as DeliveryServices));
            NavigationManager.ApdateCheck = "0";
        }



        private void cbChekDate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbChekDate.SelectedIndex == 0)
            {
                string sqlDate = "SELECT * FROM DeliveryServices" +
                                    " WHERE  EXISTS(SELECT *" +
                   " FROM Books" +
                   " WHERE DeliveryServices.Id = Books.IdDelivery)";
                btnDeleteSuplier.Visibility = Visibility.Collapsed;

                listSuppliers.ItemsSource = App.DataBase.DeliveryServices.SqlQuery(sqlDate).ToList();
            }

            if (cbChekDate.SelectedIndex == 1)
            {
                string sqlDate = "SELECT * FROM DeliveryServices" +
                                    " WHERE NOT EXISTS(SELECT *" +
                   " FROM Books" +
                   " WHERE DeliveryServices.Id = Books.IdDelivery)";
                btnDeleteSuplier.Visibility = Visibility.Visible;

                listSuppliers.ItemsSource = App.DataBase.DeliveryServices.SqlQuery(sqlDate).ToList();
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (NavigationManager.ApdateCheck == "1")
            {
                LoadData();
                NavigationManager.ApdateCheck = "0";
            }          
        }
    }
}
