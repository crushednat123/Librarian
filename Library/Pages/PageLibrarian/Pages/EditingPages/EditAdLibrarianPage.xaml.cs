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
    /// Логика взаимодействия для EditAdLibrarianPage.xaml
    /// </summary>
    public partial class EditAdLibrarianPage : Page
    {
        private Users _currentUsers = new Users();
        public static string imgSql { get; set; }
        public static string UserId { get; set; }
        public EditAdLibrarianPage(Users selectUsers)
        {
            InitializeComponent();

            if (selectUsers != null)
            {
                _currentUsers = selectUsers;
            }
            DataContext = _currentUsers;            
        }
       
        /// <summary>
        /// Запоминает логин
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e) => UserId = tBLogin.Text;       

        /// <summary>
        /// Открывает проводник с картинками 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditImage_Click(object sender, RoutedEventArgs e) =>        
            OpenFales.FalesOpenFale(textBoxImage, "Картинки Png  (*.png) | *.png; | Картинки Jpg (*.jpg) | *.jpg;");
        
        /// <summary>
        /// Кнопка сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();


            if (tBSurName.Text.Length == 0)
            {
                errors.AppendLine("\nВведите фамилию");
            }

            if (tBName.Text.Length == 0)
            {
                errors.AppendLine("\nВведите имя и отчество");
            }

            if (tBAdres.Text.Length == 0)
            {
                errors.AppendLine("\nВведите адрес");
            }

         
            if (tBLogin.Text.Length == 0)
            {
                errors.AppendLine("\nВведите логин");
            }

            if (tBPassword.Text.Length == 0)
            {
                errors.AppendLine("\nВведите пароль");
            }

            if (!tBPhone.IsMaskCompleted)
            {
                errors.AppendLine("\nНомер телефона слишком короткий");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (_currentUsers.Id != 0)
            {
                try
                {
                    string logindChek = "SELECT * FROM Users WHERE Login ='" + tBLogin.Text + "'";

                    var sql = App.DataBase.Users.SqlQuery(logindChek).ToArray();

                    if (tBLogin.Text == UserId)
                    {
                        try
                        {
                            ImageAd();
                            NavigationManager.SaveDate("3");
                        }
                        catch (Exception en)
                        {
                            MessageBox.Show(en.Message.ToString());
                        }
                    }

                    else if (tBLogin.Text != UserId)
                    {

                        sql = App.DataBase.Users.SqlQuery(logindChek).ToArray();

                        if (sql.Length != 0)
                        {
                            MessagesInfo.ErrorLogin();
                        }
                        else if (sql.Length == 0)
                        {
                            try
                            {
                                ImageAd();
                                NavigationManager.SaveDate("3");
                            }
                            catch (Exception en)
                            {
                                MessageBox.Show(en.Message.ToString());
                            }
                        }
                    }
                }
                catch
                {
                    MessagesInfo.ErrorServer();
                }
            }

            if (_currentUsers.Id == 0)
            {
                // проверка на дублирование телефона
                string teleponeChek = "SELECT * FROM Librarian WHERE Telephone ='" + tBPhone.Text + "'";
                var sql = App.DataBase.Librarian.SqlQuery(teleponeChek).ToArray();

                // проверка на дублирование логина
                string logindChek = "SELECT * FROM Users WHERE Login ='" + tBLogin.Text + "'";
                var sqlLogin = App.DataBase.Users.SqlQuery(logindChek).ToArray();

                var sqlAdTeachers = "";

                // Добавление пользователя
                sqlAdTeachers = "INSERT INTO Librarian (SurName, Name, Address, Telephone)" +
                 $" VALUES('{tBSurName.Text}', '{tBName.Text}', '{tBAdres.Text}'," +
                 $" '{tBPhone.Text}')";

                try
                {
                    if (sql.Length != 0 || sqlLogin.Length != 0)
                    {
                        if (sql.Length != 0)
                        {
                            MessagesInfo.TelephoneInfo();
                        }

                        if (sqlLogin.Length != 0)
                        {
                            MessagesInfo.ErrorLogin();
                        }

                        if (sqlLogin.Length != 0 && sql.Length != 0)
                        {
                            MessagesInfo.TelephoneAndLoginInfo();
                        }

                    }

                    if (sql.Length == 0 && sqlLogin.Length == 0)
                    {
                        //добавление библиотекаря
                        var ad = App.DataBase.Database.ExecuteSqlCommand(sqlAdTeachers);

                        // получение айдишника добавленной записи
                        var id = App.DataBase.Librarian.Where(p =>
                        p.SurName == tBSurName.Text && p.Name == tBName.Text && p.Address == tBAdres.Text
                        && p.Telephone == tBPhone.Text).Select(p => p.Id).FirstOrDefault();


                        //добавление учителя в таблицу пользователей           
                        var adUsers = "INSERT INTO Users (Login, Password, IdRole, IdLibrarian)" +
                                              $" VALUES('{tBLogin.Text}', '{tBPassword.Text}', '2'," +
                                              $" '{id}')";

                        //добавление сохранить добавление
                        var adTeachers = App.DataBase.Database.ExecuteSqlCommand(adUsers);


                        // Добавление картинки
                        if (textBoxImage.Text == "")
                        {
                            NavigationManager.SaveDate("3");
                        }
                        if (textBoxImage.Text != "")
                        {
                            if (textBoxImage.Text != "Картинка уже загружена")
                            {
                                var sqlDateImage = $"UPDATE  Librarian Set Img = (Select * From OpenRowSet(Bulk N'{textBoxImage.Text}'," +
                                    $" Single_Blob) As image) Where Id = {id};";
                                var update = App.DataBase.Database.ExecuteSqlCommand(sqlDateImage);
                            }

                            NavigationManager.SaveDate("3");
                        }
                    }

                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.ToString());
                }                
            }            
        }
        /// <summary>
        /// Добавить картинку
        /// </summary>
        public void ImageAd()
        {
            try
            {
                if (textBoxImage.Text.Length != 0)
                {
                    if (textBoxImage.Text != "Картинка уже загружена")
                    {
                        imgSql = $"UPDATE  Librarian Set Img = (Select * From OpenRowSet(Bulk N'{textBoxImage.Text}', Single_Blob) As image) Where Id = {textBlockIdUser.Text}";                       
                        var update = App.DataBase.Database.ExecuteSqlCommand(imgSql);
                    }
                }
                App.DataBase.SaveChanges();
            }
            catch
            {
                MessagesInfo.ErrorServer();
            }
        }
    }
}
