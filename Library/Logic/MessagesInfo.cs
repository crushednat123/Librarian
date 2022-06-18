using Library.Pages.PageStudent;
using Library.Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Library.Logic
{
    public class MessagesInfo
    {

        public static void Length(TextBox textBox, PasswordBox passwordBox)
        {
            if (textBox.Text.Length == 0 && passwordBox.Password.Length == 0)
            {
                MessageBox.Show("Вы не ввели логин и пароль.", "Информация",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            else if (textBox.Text.Length == 0 && passwordBox.Password.Length != 0)
            {
                MessageBox.Show("Вы не ввели логин.", "Информация",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            else if (textBox.Text.Length != 0 && passwordBox.Password.Length == 0)
            {
                MessageBox.Show("Вы не ввели пароль.", "Информация",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }

        public static void MessagesExit()
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите выйти из программы?", "Информация",

            MessageBoxButton.YesNo,
            MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            {

            }
        }      

        public static void ErrorServer()
        {
            MessageBox.Show("Ошибка подключение к серверу.", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void ErrorServerOrDocymentError()
        {
            MessageBox.Show("Ошибка подключение к серверу или документ повреждён.", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void LoginNull()
        {
            MessageBox.Show("Вы не ввели логин.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }


        public static void CheckBook()
        {
            MessageBox.Show("Данная книга присутствует в истории выдачи. Удалите её в выдаче, что бы удалить её здесь", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }


        public static void CheckUsers()
        {
            MessageBox.Show("Нельзя удалить данного пользователя, так как ему выданы книги", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void PasswordNull()
        {
            MessageBox.Show("Вы не ввели пароль.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }       

        public static void UserError()
        {
            MessageBox.Show("Не правильный логин или пароль.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void SchoolBoy()
        {
            MessageBox.Show("Вы вошли как - ученик.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void Teacher()
        {
            MessageBox.Show("Вы вошли как - учитель.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void Librarian()
        {
            MessageBox.Show("Вы вошли как - библиотекарь.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void Admin()
        {
            MessageBox.Show("Вы вошли как - администратор.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void DocymentError()
        {
            MessageBox.Show("Данный документ повреждён.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void PasswordError()
        {
            MessageBox.Show("Пароли не совпадают.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void SaveDate()
        {
            MessageBox.Show("Данные сохранены.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void ErrorLogin()
        {
            MessageBox.Show("Логин уже занят другим пользователем.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void PasswordOldNull()
        {
            MessageBox.Show("Вы не ввели старый пароль.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void PasswordNewNull()
        {
            MessageBox.Show("Вы не ввели новый пароль.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }


        public static void PasswordOldAndLogin()
        {
            MessageBox.Show("Вы не ввели логин и старый пароль.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void PasswordNewAndLogin()
        {
            MessageBox.Show("Вы не ввели логин и новый пароль.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void PasswordNewAndPasswordOld()
        {
            MessageBox.Show("Вы не ввели старый пароль и новый пароль.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void PasswordNewAndPasswordOldAndLogin()
        {
            MessageBox.Show("Вы не ввели логин, старый пароль и новый пароль.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void PostavhikInfo()
        {
            MessageBox.Show("Данный поставщик не может быть удалён, так как он связан с одной или более книг", 
                "Информация",
               MessageBoxButton.OK, MessageBoxImage.Information);
        }


        public static void NamberBokInfo()
        {
            MessageBox.Show("Такой номер у книг уже существует",
                "Информация",
               MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void TelephoneInfo()
        {
            MessageBox.Show("Телефон уже занят", "Информация",
               MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void TelephoneAndLoginInfo()
        {
            MessageBox.Show("Телефон и логин уже занят", "Информация",
               MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
