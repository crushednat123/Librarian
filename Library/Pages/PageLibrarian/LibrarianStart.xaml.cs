using Library.Logic;
using Library.Pages.PageLibrarian.Pages;
using Library.Pages.PageLibrarian.Pages.EditingPages;
using Library.Pages.PageStudent.Pages;
using Library.Start;
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
using System.Windows.Shapes;

namespace Library.Pages.PageLibrarian
{
    /// <summary>
    /// Логика взаимодействия для LibrarianStart.xaml
    /// </summary>
    public partial class LibrarianStart : Window
    {
        public LibrarianStart()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Центральное меню библиотекаря
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startLibrarian_Loaded(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame = startFrame;
            startFrame.Navigate(new MainPageLibrarian());
        }

        /// <summary>
        /// Отображает информацию о пользователе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startLibrarian_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e) => TextBlockVivod.UserInfo(tbName, tbSyrName, tbRole, Char1NameAndSurName);
        


        /// <summary>
        /// Страница связь с разработчиком
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSapport_Click(object sender, RoutedEventArgs e) =>  NavigationManager.StartFrame.Navigate(new SupportPage());
      

        
        /// <summary>
        /// Страница для редактирование данных пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditUser_Click(object sender, RoutedEventArgs e) => NavigationManager.StartFrame.Navigate(new EditLibrarianPage());
        


        /// <summary>
        /// Отображает меню с кнопками 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new MainPageLibrarian());
            NavigationManager.ApdateCheck = "0";
        }

        /// <summary>
        /// Открывает страницу с книгами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBooks_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new BookPage());
            NavigationManager.ApdateCheck = "0";
        }

        /// <summary>
        /// Кнопка назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.GoBack();
            NavigationManager.ApdateCheck = "0";
        }



        /// <summary>
        /// Выход из учётной записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitZapic_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.ExitWindow(startLibrarian, new AuthorizationWindow());
            NavigationManager.ApdateCheck = "0";
        }


        /// <summary>
        /// Позволяет двигать окно по экрану
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        /// <summary>
        /// Логика фрейма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startFrame_ContentRendered(object sender, EventArgs e)
        {
            if (startFrame.CanGoBack)
            {
                btnBack.Visibility = Visibility.Visible;
            }

            else
            {
                btnBack.Visibility = Visibility.Collapsed;
            }

            if (startFrame.Content.GetType().Name == "MainPageLibrarian")
            {
                ButtonStyles.StyleButton(btnMain, btnBooks, null, btnUserAd, btnSupplier, btnVidaca, 1);

                startLibrarian.MinWidth = 1045;
            }

            if (startFrame.Content.GetType().Name == "ExtraditionPage")              
            {
                ButtonStyles.StyleButton(btnVidaca, btnBooks, null, btnUserAd, btnSupplier, btnMain, 1);
                startLibrarian.MinWidth = 1046;
            }
            if (startFrame.Content.GetType().Name == "SuppliersPage")
            {
                ButtonStyles.StyleButton(btnSupplier, btnBooks, btnVidaca, btnUserAd, null, btnMain, 1);
            }

            if (startFrame.Content.GetType().Name == "VidachaAllBookPrint" ||
                startFrame.Content.GetType().Name == "HistoryIssuePage")
            {
                ButtonStyles.StyleButton(btnVidaca, btnBooks, null, btnUserAd, btnSupplier, btnMain, 1);
            }

            if (startFrame.Content.GetType().Name == "UserPage")
            {
                ButtonStyles.StyleButton(btnUserAd, btnBooks, btnVidaca, btnSupplier, null, btnMain, 1);
            }

            if (startFrame.Content.GetType().Name == "BookPage")
            {
                ButtonStyles.StyleButton(btnBooks, btnUserAd, btnVidaca, btnSupplier, null, btnMain, 1);
                startLibrarian.MinWidth = 1046;
            }

            if (startFrame.Content.GetType().Name == "EditBookPage")
            {                
                startLibrarian.MinHeight = 630;
            }

            
            if (startFrame.Content.GetType().Name == "SupportPage" || startFrame.Content.GetType().Name == "EditLibrarianPage")
            {
                startLibrarian.MinWidth = 970;
                ButtonStyles.StyleButton(btnMain, btnBooks, null, btnUserAd, btnSupplier, btnVidaca, 0);
            }

            if (startFrame.Content.GetType().Name == "EditUsersPage")
            {
                ButtonStyles.StyleButton(btnUserAd, btnBooks, btnVidaca, btnSupplier, null, btnMain, 1);
            }
        }


        /// <summary>
        /// Кнопка расширить или уменьшить окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpand_Click(object sender, RoutedEventArgs e) => Expands.ExpandsWindow(startLibrarian, iconExpand, btnExpand);
       


        /// <summary>
        /// Закрывает программу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e) => MessagesInfo.MessagesExit();
       


        /// <summary>
        /// Кнопка свернуть окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRollUp_Click(object sender, RoutedEventArgs e) => startLibrarian.WindowState = WindowState.Minimized;
       


        /// <summary>
        /// Открывает страницу с поставщиками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupplier_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new SuppliersPage());
            NavigationManager.ApdateCheck = "0";
        }


        /// <summary>
        /// Открывает страницу со всеми пользователями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserAd_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new UserPage());
            NavigationManager.ApdateCheck = "0";
        }


        /// <summary>
        /// Открывает страницу выдачи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVidaca_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new ExtraditionPage());
            NavigationManager.ApdateCheck = "0";
        }
    }
}
