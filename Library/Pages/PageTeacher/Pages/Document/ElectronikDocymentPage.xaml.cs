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

namespace Library.Pages.PageTeacher.PagesTeachers.Pages.Document
{
    /// <summary>
    /// Логика взаимодействия для ElectronikDocymentPage.xaml
    /// </summary>
    public partial class ElectronikDocymentPage : Page
    {
        private Extraditions _currentBook = new Extraditions();

        public ElectronikDocymentPage(Extraditions selectExtradion)
        {
            InitializeComponent();

            if (selectExtradion != null)
            {

                _currentBook = selectExtradion;
            }

           
            DataContext = _currentBook;
        }


        /// <summary>
        /// Выводит документ
        /// </summary>
        public void DocumentShow()
        {

            var arrya = App.DataBase.Books

           .Where(i => i.Id.ToString() == tbId.Text)
           .Select(i => i.ElectronicVersion).Single();

            //преобразовывает массив в документ 
            DocymentConvertToXPS.DocymentReader(arrya, doc);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e) => DocumentShow();
       

        private void btnPrint_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.Handled = true;
       

        private void btnCopy_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.Handled = true;
       
    }
}
