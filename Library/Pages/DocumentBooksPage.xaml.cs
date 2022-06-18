using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.IO.Packaging;
using System.Windows.Documents;

using Microsoft.Win32;
using System.Windows.Xps.Packaging;
using System.Data.SqlClient;
using System.Data;
using Library.Logic;
using Library.Entities;

namespace Library.Pages
{
    /// <summary>
    /// Логика взаимодействия для DocumentBooksPage.xaml
    /// </summary>
    public partial class DocumentBooksPage : Page
    {
        private Books _currentBook = new Books();
      

        public DocumentBooksPage(Books selectBook)
        {
            InitializeComponent();

            if (selectBook != null)
            {              
                _currentBook = selectBook;
            }
            
            DataContext = _currentBook;         
        }

       
        /// <summary>
        /// Отображает документ
        /// </summary>
        public void DocumentShow()
        {          
           var arrya = App.DataBase.Books

           .Where(i => i.Id.ToString() == tbId.Text)
           .Select(i => i.ElectronicVersion).Single();

            //преобразовывает массив в документ 
            DocymentConvertToXPS.DocymentReader(arrya, doc);


        }

        /// <summary>
        /// Срабатывает при полной привязке 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e) => DocumentShow();
       

        /// <summary>
        /// Отключает кнопку печати
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e) => e.Handled = true;
       

        /// <summary>
        /// Отключает кнопку копирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e) => e.Handled = true;
        
    }
}

