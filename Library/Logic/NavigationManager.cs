using Library.Start;
using System.Windows;
using System.Windows.Controls;

namespace Library.Logic 
{
    public static class NavigationManager
    {
        public static Frame StartFrame { get; set; }
 
        public static string ApdateCheck { get; set; }

        public static string TextBoxIsRedonly { get; set; }
        

        public static byte TypeBattun { get; set; }




        public static void ExitWindow(Window startWindow, Window authorization)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите выйти из учётной записи?", "Информация",

                        MessageBoxButton.YesNo,
                        MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                startWindow.Visibility = Visibility.Collapsed;

                authorization = new AuthorizationWindow();
                authorization.Show();
            }           
        }

        /// <summary>
        /// Сохранение
        /// </summary>
        public static void SaveDate(string a)
        {
            App.DataBase.SaveChanges();
            MessagesInfo.SaveDate();
            ApdateCheck = a;
            StartFrame.GoBack();
        }

    }    
}
