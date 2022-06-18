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

namespace Library.Pages.PageTeacher.PagesTeachers.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditUserPage.xaml
    /// </summary>
    public partial class EditUserPage : Page
    {
        public EditUserPage()
        {
            InitializeComponent();

            cBItems.ItemsSource = App.DataBase.Items.ToList();
            cBClasses.ItemsSource = App.DataBase.Classes.ToList();           
            border.DataContext = App.DataBase.Users.Where(p => p.IdTeachers.ToString() == DateUser.Id).ToArray();
            DataContext = border;
        }

        /// <summary>
        /// Сбрасывает фокус при нажатии на бордер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => FocusFalse();
       

        /// <summary>
        /// Возникает при получении фокуса в tbLogin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBLogin_GotFocus(object sender, RoutedEventArgs e) =>
            ColorIconImages.ForegroundIcon(iconLogin, iconPassword, iconName, iconSurName, iconItems, iconAdres, iconPhone, iconClasses, 1);
        
        /// <summary>
        /// Возникает при получении фокуса в pBPassword
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBPassword_GotFocus(object sender, RoutedEventArgs e) =>
            ColorIconImages.ForegroundIcon(iconPassword, iconLogin, iconName, iconSurName, iconItems, iconAdres, iconPhone, iconClasses, 1);
        
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
        /// Возникает при получении фокуса в tBPassword
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBPassword_GotFocus(object sender, RoutedEventArgs e) => 
            ColorIconImages.ForegroundIcon(iconPassword, iconLogin, iconName, iconSurName, iconItems, iconAdres, iconPhone, iconClasses, 1);
        

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
        /// Возникает при потери фокуса в текстовых полях
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_GotFocus(object sender, RoutedEventArgs e) => FocusFalse();
        
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
                errors.AppendLine("Номер телефона слишком короткий");

            if (string.IsNullOrWhiteSpace(cBItems.Text))
            {
                errors.AppendLine("\nВыберите свой предмет");
            }
         
            if (string.IsNullOrWhiteSpace(cBClasses.Text))
            {
                errors.AppendLine("\nВыберите свой класс");
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
                    string updateLoginPassword = $"UPDATE Users SET Login ='{tBLogin.Text}' , password ='{tBPassword.Text}' Where IdTeachers ='{DateUser.Id}'";
                    var sql = App.DataBase.Users.SqlQuery(logindChek).ToArray();
                   
                    if (tBLogin.Text == DateUser.Login)
                    {
                        try
                        {
                            var update = App.DataBase.Database.ExecuteSqlCommand(updateLoginPassword);

                            MessagesInfo.SaveDate();
                            App.DataBase.SaveChanges();
                            NavigationManager.StartFrame.Navigate(new MainPagesTechers());
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
                                MessagesInfo.SaveDate();
                                App.DataBase.SaveChanges();
                                NavigationManager.StartFrame.Navigate(new MainPagesTechers());
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

        /// <summary>
        /// Скрывает и отображает пароль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkPassword_Click(object sender, RoutedEventArgs e)
        {
            FocusFalse();

            CheckBoxCheket.CheckBoxPasswordChek(checkPassword, pBPassword, tBPassword);
        }

        /// <summary>
        /// Меняет цвет иконок, также убирает фокус с текстовых полей
        /// </summary>
        public void FocusFalse()
        {
            border.Focus();
            ColorIconImages.ForegroundIcon(iconLogin, iconPassword,iconName,iconSurName, iconItems, iconAdres, iconPhone, iconClasses, 0);
        }

        /// <summary>
        /// Меняет цвет иконки у имени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBName_GotFocus(object sender, RoutedEventArgs e) =>
            ColorIconImages.ForegroundIcon(iconName, iconPassword, iconLogin, iconSurName, iconItems, iconAdres, iconPhone, iconClasses, 1);
       
        /// <summary>
        /// Меняет цвет иконки у фамилии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBSurName_GotFocus(object sender, RoutedEventArgs e) => 
            ColorIconImages.ForegroundIcon(iconSurName, iconPassword, iconLogin, iconName, iconItems, iconAdres, iconPhone, iconClasses, 1);
       
        /// <summary>
        /// Меняет цвет иконки у предмета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBItems_GotFocus(object sender, RoutedEventArgs e) =>
            ColorIconImages.ForegroundIcon(iconItems, iconSurName, iconPassword, iconLogin, iconName, iconAdres, iconPhone, iconClasses, 1);
       

        private void tBAdres_GotFocus(object sender, RoutedEventArgs e) =>
            ColorIconImages.ForegroundIcon(iconAdres, iconItems, iconSurName, iconPassword, iconLogin, iconName, iconPhone, iconClasses, 1);
       

        private void tBPhone_GotFocus(object sender, RoutedEventArgs e) =>
            ColorIconImages.ForegroundIcon(iconPhone, iconAdres, iconItems, iconSurName, iconPassword, iconLogin, iconName, iconClasses, 1);
      
        
        private void cBClasses_GotFocus(object sender, RoutedEventArgs e) =>
            ColorIconImages.ForegroundIcon(iconClasses, iconPhone, iconAdres, iconItems, iconSurName, iconPassword, iconLogin, iconName, 1);
       
    }
}
