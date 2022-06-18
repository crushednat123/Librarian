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

namespace Library.Pages.PageLibrarian.Pages.EditingPages
{
    /// <summary>
    /// Логика взаимодействия для EditSupplierPage.xaml
    /// </summary>
    public partial class EditSupplierPage : Page
    {
        private DeliveryServices _currentSlupper = new DeliveryServices();
        public EditSupplierPage(DeliveryServices deliveryServices)
        {
            InitializeComponent();

            if (deliveryServices != null)
            {
                _currentSlupper = deliveryServices;
            }

            DataContext = _currentSlupper;

            cBPostovhik.ItemsSource = App.DataBase.TypeSuppliers.ToList();
        }


        /// <summary>
        /// Кнопка сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentSlupper.SupplierName))
            {
                error.AppendLine("\nВведите ФИО");
            }

            if (!tBPhone.IsMaskCompleted)
            {
                error.AppendLine("Номер телефона слишком короткий");
            }
           
            if (_currentSlupper.TypeSuppliers == null)
            {
                error.AppendLine("\nВыберите тип поставщика");
            }


            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (_currentSlupper.Id != 0)
            {
                try
                {
                    App.DataBase.SaveChanges();
                    MessagesInfo.SaveDate();
                    NavigationManager.ApdateCheck = "1";
                    NavigationManager.StartFrame.GoBack();
                }

                catch
                {
                    MessagesInfo.ErrorServer();
                }
            }
            if (_currentSlupper.Id == 0)
            {
                try
                {
                    App.DataBase.DeliveryServices.Add(_currentSlupper);
                    App.DataBase.SaveChanges();
                    MessagesInfo.SaveDate();
                    NavigationManager.ApdateCheck = "1";
                    NavigationManager.StartFrame.GoBack();
                }

                catch
                {
                    MessagesInfo.ErrorServer();
                }
            }
        }
    }
}
