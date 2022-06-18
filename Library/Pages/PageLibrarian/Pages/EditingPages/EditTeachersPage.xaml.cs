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
    /// Логика взаимодействия для EditUsersPage.xaml
    /// </summary>
    public partial class EditTeachersPage : Page
    {
        private Users _currentUsers = new Users();

        public static string imgSql { get; set; }
        public static string UserId { get; set; }
        public EditTeachersPage(Users selectUsers)
        {
            InitializeComponent();

            if (selectUsers != null)
            {
                _currentUsers = selectUsers;
            }
            DataContext = _currentUsers;

            cbClasses.ItemsSource = App.DataBase.Classes.ToList();
        }

        /// <summary>
        /// Добавить картинку
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

            if (NavigationManager.ApdateCheck == "1")
            {
                if (_currentUsers.Teachers.IdClasses == null)
                {
                    errors.AppendLine("\nВыберите класс");
                }
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
                string teleponeChek = "SELECT * FROM Teachers WHERE Telephone ='" + tBPhone.Text + "'";
                var sql = App.DataBase.Teachers.SqlQuery(teleponeChek).ToArray();

                // проверка на дублирование логина
                string logindChek = "SELECT * FROM Users WHERE Login ='" + tBLogin.Text + "'";
                var sqlLogin = App.DataBase.Users.SqlQuery(logindChek).ToArray();

                var sqlAdTeachers = "";


                   // Добавление пользователя
                   sqlAdTeachers = "INSERT INTO Teachers (SurName, Name, Address, IdClasses, Telephone)" +
                    $" VALUES('{tBSurName.Text}', '{tBName.Text}', '{tBAdres.Text}'," +
                    $" '{tbIdClasses.Text}', '{tBPhone.Text}')";


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
                        //добавление учителя
                        var ad = App.DataBase.Database.ExecuteSqlCommand(sqlAdTeachers);

                        // получение айдишника добавленной записи
                        var id = App.DataBase.Teachers.Where(p =>
                        p.SurName == tBSurName.Text && p.Name == tBName.Text && p.Address == tBAdres.Text
                        && p.Telephone == tBPhone.Text).Select(p => p.Id).FirstOrDefault();


                        //добавление учителя в таблицу пользователей           
                        var adUsers = "INSERT INTO Users (Login, Password, IdRole, IdTeachers)" +
                                              $" VALUES('{tBLogin.Text}', '{tBPassword.Text}', '3'," +
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
                                var sqlDateImage = $"UPDATE  Teachers Set Img = (Select * From OpenRowSet(Bulk N'{textBoxImage.Text}'," +
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
                        imgSql = $"UPDATE  Teachers Set Img = (Select * From OpenRowSet(Bulk N'{textBoxImage.Text}', Single_Blob) As image) Where Id = {textBlockIdUser.Text}";                        
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


        /// <summary>
        /// Получение айдишника класса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbClasses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (cbClasses.SelectedItem != null)
                {
                    tbIdClasses.Text = (cbClasses.SelectedItem as Classes).Id.ToString();
                }
            }
            catch
            {
                MessagesInfo.ErrorServer();
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (NavigationManager.ApdateCheck == "2")
            {
                cbClasses.SelectedIndex = Convert.ToInt32(DateUser.IdClasses) - 1;
                cbClasses.IsEnabled = false;
            }

            if (DateUser.IdRole == "2")
            {
                cbClasses.IsEnabled = true;

                if (NavigationManager.ApdateCheck == "2")
                {
                    cbClasses.Text = null;
                }
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e) => UserId = tBLogin.Text;
       
    }
}
