using Library.Logic;
using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;
using Library.Pages.PageStudent;
using Library.Pages.PageTeacher;
using Library.Pages.PageAdmin;
using Library.Entities;
using Library.Pages.PageLibrarian;

namespace Library.Start
{


    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Перемещает окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
            FocusFalse();
        }

        /// <summary>
        /// Сбрасывает фокус и цвет иконок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => FocusFalse();

        /// <summary>
        /// Меняет цвет иконок, также убирает фокус с текстовых полей
        /// </summary>
        public void FocusFalse()
        {
            border.Focus();
            ColorIconImages.ForegroundIcon(iconLogin, iconPassword,null,null, null, null, null, null, 0);
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
        /// Кнопка закрыть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessagesInfo.MessagesExit();
            FocusFalse();
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
        /// Кнопка войти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVhod_Click(object sender, RoutedEventArgs e)
        {
            FocusFalse();
         
            StartSchoolboy startSchoolboy = new StartSchoolboy();
            TeacherStart teacherStart =  new TeacherStart();
            AdminStart admin = new AdminStart();
            LibrarianStart librarian = new LibrarianStart();

            if (tBLogin.Text.Length == 0 || pBPassword.Password.Length == 0)
            {
                MessagesInfo.Length(tBLogin, pBPassword);
            }
            else
            {               
                try
                {
                    if (checkPassword.IsChecked == true)
                    {
                        pBPassword.Password = tBPassword.Text;
                    }

                    //Авторизация
                    var user = App.DataBase.Users.Where(p =>
                    p.Login == tBLogin.Text && p.Password == pBPassword.Password).FirstOrDefault();

                    if (user != null)
                    {
                        DateUser.Login = Convert.ToString(user.Login);
                        DateUser.IdRole = Convert.ToString(user.IdRole);

                        if (user.IdRole == 3)
                        {
                          
                            DateUser.IdCinderCode = "Учитель";                           
                            DateUser.IdClasses = Convert.ToString(user.Teachers.IdClasses);
                            DateUser.Name = user.Teachers.Name;
                            DateUser.SurName = user.Teachers.SurName;
                           

                            DateUser.Id = Convert.ToString(user.IdTeachers);


                            //Информация кто вошёл
                            MessagesInfo.Teacher();


                            window.Visibility = Visibility.Collapsed;
                           

                            teacherStart.Show();
                            
                        }

                        if (user.IdRole == 4)
                        {
                            //заполнение полей                                                 
                            DateUser.IdCinderCode = "Ученик";                                                  
                            DateUser.Name = user.SchoolBoy.Name;
                            DateUser.SurName = user.SchoolBoy.SurName;
                            DateUser.Id = Convert.ToString(user.IdSchool);

                           

                            //Информация кто вошёл
                            MessagesInfo.SchoolBoy();


                            window.Visibility = Visibility.Collapsed;
                            startSchoolboy.Show();
                            
                        }

                        if (user.IdRole == 1)
                        {

                            MessagesInfo.UserError();
                            
                        }

                        if(user.IdRole == 2)
                        {
                            DateUser.Id = Convert.ToString(user.IdLibrarian);
                            MessagesInfo.Librarian();
                            window.Visibility = Visibility.Collapsed;
                            DateUser.Name = user.Librarian.Name;
                            DateUser.SurName = user.Librarian.SurName;
                            DateUser.IdCinderCode = "Библиотекарь";
                            librarian.Show();
                        }
                    }
                    else
                    {
                        MessagesInfo.UserError();
                    }
                }
                catch
                {
                    MessagesInfo.ErrorServer();
                }            
            }
        }
      
        /// <summary>
        /// Возникает при получении фокуса в tbLogin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBLogin_GotFocus(object sender, RoutedEventArgs e) => ColorIconImages.ForegroundIcon(iconLogin, iconPassword, null, null, null, null, null, null, 1);
       
        /// <summary>
        /// Возникает при получении фокуса в pBPassword
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBPassword_GotFocus(object sender, RoutedEventArgs e) => ColorIconImages.ForegroundIcon(iconPassword, iconLogin, null, null, null, null, null, null, 1);
        
        /// <summary>
        /// Возникает при получении фокуса в tBPassword
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBPassword_GotFocus(object sender, RoutedEventArgs e) => ColorIconImages.ForegroundIcon(iconPassword, iconLogin, null, null, null, null, null, null, 1);
        
        /// <summary>
        /// Возникает при потери фокуса в текстовых полях
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVhod_GotFocus(object sender, RoutedEventArgs e) => FocusFalse();
        
    }
    
}
