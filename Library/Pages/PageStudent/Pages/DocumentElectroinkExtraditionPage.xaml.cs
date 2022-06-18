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

namespace Library.Pages.PageStudent.Pages
{
    /// <summary>
    /// Логика взаимодействия для DocumentElectroinkExtraditionPage.xaml
    /// </summary>
    public partial class DocumentElectroinkExtraditionPage : Page
    {

        private Extraditions _currentBook = new Extraditions();

        public DocumentElectroinkExtraditionPage(Extraditions selectExtradion)
        {
            InitializeComponent();


            if (selectExtradion != null)
            {

                _currentBook = selectExtradion;


            }
            
            DataContext = _currentBook;
        }

        /// <summary>
        /// Срабатывает при полной привязке 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e) => DocumentShow();
       

        public void DocumentShow()
        {

            var arrya = App.DataBase.Books

           .Where(i => i.Id.ToString() == tbId.Text)
           .Select(i => i.ElectronicVersion).Single();

            //преобразовывает массив в документ 
            DocymentConvertToXPS.DocymentReader(arrya, doc);
        }


        /// <summary>
        /// Отключает кнопку печати
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.Handled = true;
       

        /// <summary>
        /// Отключает кнопку копирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.Handled = true;
       
    }
}
