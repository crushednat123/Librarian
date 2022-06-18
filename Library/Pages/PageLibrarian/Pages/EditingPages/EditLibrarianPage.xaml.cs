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
    /// Логика взаимодействия для EditLibrarianPage.xaml
    /// </summary>
    public partial class EditLibrarianPage : Page
    {
        public static string imgSql { get; set; }
        public static string UserId { get; set; }

        public EditLibrarianPage()
        {
            InitializeComponent();
            border.DataContext = App.DataBase.Users.Where(p => p.IdLibrarian.ToString() == DateUser.Id).ToArray();
            DataContext = border;
        }

        /// <summary>
        /// Кнопка сохранения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            tBPassword.Text = pBPassword.Password;

            if (string.IsNullOrWhiteSpace(tBName.Text))
            {
                errors.AppendLine("\nВведите имя");
            }
            if (string.IsNullOrWhiteSpace(tBSurName.Text))
            {
                errors.AppendLine("\nВведите фамилию");
            }

            if (string.IsNullOrWhiteSpace(tBAdres.Text))          
            {
                errors.AppendLine("\nВведите адрес");
            }

            if (!tBPhone.IsMaskCompleted)
            {
                errors.AppendLine("\nНомер телефона слишком короткий");
            }

            if (string.IsNullOrWhiteSpace(tBLogin.Text))
            {
                errors.AppendLine("\nВведите логин");
            }

            if (string.IsNullOrWhiteSpace(pBPassword.Password))
            {
                errors.AppendLine("\nВведите пароль");
            }


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (tBId.Text != "0")
            {
                try
                {                    
                    string logindChek = "SELECT * FROM Users WHERE Login ='" + tBLogin.Text + "'";
                    string updateLoginPassword = $"UPDATE Users SET Login ='{tBLogin.Text}' , password ='{tBPassword.Text}' Where IdLibrarian ='{DateUser.Id}'";
                    var sql = App.DataBase.Users.SqlQuery(logindChek).ToArray();

                    if (tBLogin.Text == DateUser.Login)
                    {
                        try
                        {
                            var update = App.DataBase.Database.ExecuteSqlCommand(updateLoginPassword);
                            ImageAd();
                            NavigationManager.SaveDate("0");
                        }
                        catch (Exception en)
                        {
                            MessageBox.Show(en.Message.ToString());
                        }
                    }

                    else if (tBLogin.Text != DateUser.Login)
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
                               NavigationManager.SaveDate("0");
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
        }


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


        /// <summary>
        /// Скрывает или отображает текстовое поле с паролем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBoxChangeds.TextLoginChanged(tBPassword, textBlockPassword, pasText);

            TextColors.ElementColor(pasText, text);
        }

        /// <summary>
        /// Скрывает или отображает PasswordBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordChangeds.TextPasswordCheck(pBPassword, textBlockPassword, pasText, checkPassword);

            TextColors.ElementColor(pasText, text);
        }


        /// <summary>
        /// Скрывает и отображает пароль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkPassword_Click(object sender, RoutedEventArgs e) =>
            CheckBoxCheket.CheckBoxPasswordChek(checkPassword, pBPassword, tBPassword);


        /// <summary>
        /// Редактировать фотографию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditImage_Click(object sender, RoutedEventArgs e) =>       
             OpenFales.FalesOpenFale(textBoxImage, "Картинки Png  (*.png) | *.png; | Картинки Jpg (*.jpg) | *.jpg;");
       
    }
}
