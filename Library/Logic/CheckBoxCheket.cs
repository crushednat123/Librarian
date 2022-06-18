using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Library.Logic
{
    public class CheckBoxCheket
    {
        /// <summary>
        /// Скрывает и отображает пароль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void CheckBoxPasswordChek(CheckBox checkBox, PasswordBox passwordBox, TextBox textBox)
        {
            if (checkBox.IsChecked == false)
            {
                if(passwordBox == null && textBox == null)
                {
                    passwordBox.Visibility = Visibility.Visible;
                    textBox.Visibility = Visibility.Collapsed;
                    checkBox.Content = "Показать пароль";
                    passwordBox.Password = textBox.Text;
                }
                
                else if (passwordBox != null && textBox != null)
                {
                    passwordBox.Visibility = Visibility.Visible;                  
                    textBox.Visibility = Visibility.Collapsed;                   
                    checkBox.Content = "Показать пароль";
                    passwordBox.Password = textBox.Text;
                    
                }
            }
            else
            {
                if (passwordBox == null && textBox == null)
                {
                    passwordBox.Visibility = Visibility.Collapsed;
                    textBox.Visibility = Visibility.Visible;
                    checkBox.Content = "Скрыть пароль";
                    textBox.Text = passwordBox.Password;
                }
                else if (passwordBox != null && textBox != null)
                { 
                    passwordBox.Visibility = Visibility.Collapsed;                   
                    textBox.Visibility = Visibility.Visible;                   
                    checkBox.Content = "Скрыть пароль";
                    textBox.Text = passwordBox.Password;
                   
                }
            }
        }
    }
}
