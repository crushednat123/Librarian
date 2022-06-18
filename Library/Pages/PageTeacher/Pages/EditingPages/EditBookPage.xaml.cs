using Library.Entities;
using Library.Logic;
using Library.Pages.PageStudent.Pages;
using Microsoft.Win32;
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
using MessageBox = System.Windows.MessageBox;


namespace Library.Pages.PageTeacher.PagesTeachers.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditBookPage.xaml
    /// </summary>
    public partial class EditBookPage : Page
    {
        private Books _currentBook = new Books();

        public static string sqlDateImage = "";
        public static string sqlDateDocument = "";
        public static string sqlLocaciaBook = "";
      
        /// <summary>
        /// Меняет местоположение книги
        /// </summary>
        public void ApdeteLocationBook()
        {
            if (cbBoxLocalBok.SelectedIndex == 0)
            {
                sqlLocaciaBook = $"UPDATE  Books Set IdBookLocation = 1 Where Id = {_currentBook.Id}";               
                var updateLocacia = App.DataBase.Database.ExecuteSqlCommand(sqlLocaciaBook);                          
            }
            if (cbBoxLocalBok.SelectedIndex == 1)
            {
                sqlLocaciaBook = $"UPDATE  Books Set IdBookLocation = 2 Where Id = {_currentBook.Id}";
                var updateLocacia = App.DataBase.Database.ExecuteSqlCommand(sqlLocaciaBook);              
            }
        }

        public EditBookPage(Books selectBook)
        {
            InitializeComponent();

            if (selectBook != null)
            {
                _currentBook = selectBook;
            }
           
            DataContext = _currentBook;

            cbItems.ItemsSource = App.DataBase.Items.ToList().OrderBy(p => p.Name);
            cBPostovhik.ItemsSource = App.DataBase.DeliveryServices.ToList().OrderBy(p => p.SupplierName);
            cbBoxClass.ItemsSource = App.DataBase.Classes.ToList().OrderBy(p => p.Number);       
            cbBoxLocalBok.ItemsSource = App.DataBase.TypeOfHalls.Where(p => p.Id != 3).ToArray();

        }


        /// <summary>
        /// Запрос на добавление картинки и документа
        /// </summary>
        /// <param name="column"></param>
        /// <param name="textBox"></param>
        /// <param name="textBlock"></param>
        public void SqlRequestImageAndDocument(TextBox textBox, TextBlock textBlock, int param)
        {
            if(param == 1)
            {
                sqlDateImage = $"UPDATE  Books Set Image = (Select * From OpenRowSet(Bulk N'{textBox.Text}', Single_Blob) As image) Where Id = {textBlock.Text};";

            }
            if (param == 2)
            {
                sqlDateDocument = $"UPDATE  Books Set ElectronicVersion = (Select * From OpenRowSet(Bulk N'{textBox.Text}', Single_Blob) As image) Where Id = {textBlock.Text};";                
            }   
            
            if (param == 3)
            {
                sqlDateDocument = $"UPDATE  Books Set ElectronicVersion = (Select * From OpenRowSet(Bulk N'{textBox.Text}', Single_Blob) As image) Where Id = {_currentBook.Id};";
            }
            if (param == 4)
            {
                sqlDateImage = $"UPDATE  Books Set Image = (Select * From OpenRowSet(Bulk N'{textBox.Text}', Single_Blob) As image) Where Id = {_currentBook.Id};";

            }
        }
      
        /// <summary>
        /// Сохранение данных
        /// </summary>
        public void SaveDate()
        {      
            StringBuilder errors = new StringBuilder();
          
            if (tbRole.Text == "2")
            {
                if (tbNameBook.Text.Length == 0)
                {
                    errors.AppendLine("\nВведите название книги");
                }

                if(tbNumberBook.Text.Length == 0)
                {
                    if (tbNumberBook.IsReadOnly == false)
                    {
                        if (string.IsNullOrWhiteSpace(_currentBook.NamberBook.ToString()))
                        {
                            errors.AppendLine("\nДобавьте  номер книги");
                        }
                    }

                }


                if (_currentBook.Items == null)
                {
                    errors.AppendLine("\nВыберите предмет книги");
                }

                if (textBoxCost.Text.Length == 0)
                {

                    errors.AppendLine("\nВведите цену книги");
                }
                if (_currentBook.Cost < 0)
                {
                    errors.AppendLine("\nЦена должна быть больше 0!");
                }

                if (string.IsNullOrWhiteSpace(_currentBook.AuthorOfThebook))
                {
                    errors.AppendLine("\nВведите автора книги");
                }

                if (_currentBook.YearOfPublication == null)
                {
                    errors.AppendLine("\nУкажите дату публикации");

                }

                if (_currentBook.DeliveryServices == null)
                {
                    errors.AppendLine("\nВыберите поставщика");
                }

                if (_currentBook.DeliveryDate == null)
                {
                    errors.AppendLine("\nУкажите дату поставки");
                }

                if (_currentBook.Classes == null)
                {
                    errors.AppendLine("\nВыберите класс");
                }


               if(cbBoxLocalBok.Text.Length == 0)
               {
                  errors.AppendLine("\nВыберите местоположение книги");
               }
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (_currentBook.Id != 0)
            {
               if(textBoxDocument.Text == "" && textBoxImage.Text == "")
               {

               }
               else if (textBoxDocument.Text != "" || textBoxImage.Text != "")
               {
                    if(textBoxDocument.Text != "")
                    {
                        if (textBoxDocument.Text != "Документ уже загружен")
                        {
                            SqlRequestImageAndDocument(textBoxDocument, tbIdBook, 2);
                            var update = App.DataBase.Database.ExecuteSqlCommand(sqlDateDocument);
                        }
                    }

                    if(textBoxImage.Text != "")
                    {
                        if (textBoxImage.Text != "Картинка уже загружена")
                        {
                            SqlRequestImageAndDocument(textBoxImage, tbIdBook, 1);
                            var update = App.DataBase.Database.ExecuteSqlCommand(sqlDateImage);
                        }
                    }

                    if (textBoxDocument.Text != "" && textBoxImage.Text != "")
                    {
                        if (textBoxDocument.Text != "Документ уже загружен" &&
                        textBoxImage.Text != "Картинка уже загружена")
                        {
                            SqlRequestImageAndDocument(textBoxDocument, tbIdBook, 2);
                            var updateDoc = App.DataBase.Database.ExecuteSqlCommand(sqlDateDocument);

                            SqlRequestImageAndDocument(textBoxImage, tbIdBook, 1);
                            var updateImage = App.DataBase.Database.ExecuteSqlCommand(sqlDateImage);
                        }   
                    }
               }                              
                try
                {
                    App.DataBase.SaveChanges();
                    ApdeteLocationBook();
                    MessagesInfo.SaveDate();
                    NavigationManager.ApdateCheck = "1";
                    NavigationManager.StartFrame.GoBack();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                            
            }
                   
            
            if (_currentBook.Id == 0)
            {
                CheckNamberBook();
            }
        }


        /// <summary>
        /// Срабатывает при добавлении книги
        /// </summary>
        public void CheckNamberBook()
        {
            try
            {              
                string namberCher = $"Select * From Books Where NamberBook = {tbNumberBook.Text}";
                var sql = App.DataBase.Books.SqlQuery(namberCher).ToArray();

                if (sql.Length != 0)
                {
                    MessagesInfo.NamberBokInfo();
                }

                if (sql.Length == 0)
                {
                    App.DataBase.Books.Add(_currentBook);

                    MessagesInfo.SaveDate();

                    App.DataBase.SaveChanges();

                    if (textBoxDocument.Text == "" && textBoxImage.Text == "")
                    {
                        App.DataBase.SaveChanges();
                    }
                    else if (textBoxDocument.Text != "" || textBoxImage.Text != "")
                    {
                        if (textBoxDocument.Text != "")
                        {
                            if (textBoxDocument.Text != "Документ уже загружен")
                            {
                                SqlRequestImageAndDocument(textBoxDocument, null, 3);
                                var update = App.DataBase.Database.ExecuteSqlCommand(sqlDateDocument);
                            }
                        }

                        if (textBoxImage.Text != "")
                        {
                            if (textBoxImage.Text != "Картинка уже загружена")
                            {
                                SqlRequestImageAndDocument(textBoxImage, null, 4);
                                var update = App.DataBase.Database.ExecuteSqlCommand(sqlDateImage);
                            }
                        }

                        if (textBoxDocument.Text != "" && textBoxImage.Text != "")
                        {
                            if (textBoxDocument.Text != "Документ уже загружен" &&
                            textBoxImage.Text != "Картинка уже загружена")
                            {
                                SqlRequestImageAndDocument(textBoxDocument, null, 3);
                                var updateDoc = App.DataBase.Database.ExecuteSqlCommand(sqlDateDocument);

                                SqlRequestImageAndDocument(textBoxImage, null, 4);
                                var updateImage = App.DataBase.Database.ExecuteSqlCommand(sqlDateImage);
                            }
                        }
                        App.DataBase.SaveChanges();
                    }

                    else if (textBoxImage.Text == "Картинка уже загружена" &&
                             textBoxDocument.Text == "Документ уже загружен")
                    {
                        App.DataBase.SaveChanges();

                    }
                    ApdeteLocationBook();
                    NavigationManager.ApdateCheck = "1";
                    NavigationManager.StartFrame.GoBack();
                }
            }
            catch
            {
                MessagesInfo.ErrorServer();
            }
        }
            
        /// <summary>
        /// Кнопка сохранения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e) => SaveDate();


        /// <summary>
        /// Кнопка добавление картинки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditImage_Click(object sender, RoutedEventArgs e) => OpenFales.FalesOpenFale(textBoxImage, "Картинки Png  (*.png) | *.png; | Картинки Jpg (*.jpg) | *.jpg;");


        /// <summary>
        /// Кнопка добавление документа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditDocument_Click(object sender, RoutedEventArgs e) => OpenFales.FalesOpenFale(textBoxDocument, "Документ XPS  (*.xps) | *.xps");


        /// <summary>
        /// Установка даты  публикации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpYearPublisher_CalendarOpened(object sender, RoutedEventArgs e) => dpYearPublisher.SelectedDate = DateTime.Now.Date;

        /// <summary>
        /// Установка даты  поставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpDatePostavka_CalendarOpened(object sender, RoutedEventArgs e) => dpDatePostavka.SelectedDate = DateTime.Now.Date;
       

        /// <summary>
        /// Проверяет какая была кнопка нажата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {                    
            if (NavigationManager.TextBoxIsRedonly == "0")
            {
                tbNumberBook.IsReadOnly = false;               
            }

            if(NavigationManager.TextBoxIsRedonly == "1")
            {
                tbNumberBook.IsReadOnly = true;               
            }
        }
    }
}
