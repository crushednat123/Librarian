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
using Library.Entities;
using Library.Logic;
using Library.Pages.PageStudent.Pages;
using Library.Start;

namespace Library.Pages.PageStudent
{
    /// <summary>
    /// Логика взаимодействия для StartSchoolboy.xaml
    /// </summary>
    public partial class StartSchoolboy : Window
    {

        public StartSchoolboy()
        {
            InitializeComponent();                    
        }

       
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

            if (startFrame.Content.GetType().Name == "MainPage")
            {
                ButtonStyles.StyleButton(btnMain, btnMyBooks, btnBooks, btnExitZapic,null, null, 1);
                btnBack.Visibility = Visibility.Collapsed;
                startWindow.MinWidth = 775;
            }

            if (startFrame.Content.GetType().Name == "MyBookPage")
            {
                ButtonStyles.StyleButton(btnMyBooks, btnMain, btnBooks, btnExitZapic, null, null, 1);
                startWindow.MinWidth = 890;
            }

            if (startFrame.Content.GetType().Name == "BookPage")
            {
                ButtonStyles.StyleButton(btnBooks, btnMyBooks, btnMain, btnExitZapic, null, null, 1);
                startWindow.MinWidth = 885;
            }

            if (startFrame.Content.GetType().Name == "EditUserPage")
            {
                ButtonStyles.StyleButton(btnBooks, btnMyBooks, btnMain, btnExitZapic, null, null, 0);
                startWindow.MinWidth = 885;
            }

            if (startFrame.Content.GetType().Name == "SupportPage")
            {
                startWindow.MinWidth = 970;
                ButtonStyles.StyleButton(btnBooks, btnMyBooks, btnMain, btnExitZapic, null, null, 0);
            }
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
        /// Кнопка выход из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e) => MessagesInfo.MessagesExit();
        

        /// <summary>
        /// Кнопка расширить или уменьшить окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpand_Click(object sender, RoutedEventArgs e) => Expands.ExpandsWindow(startWindow, iconExpand, btnExpand);           
      

        /// <summary>
        /// Кнопка свернуть окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRollUp_Click(object sender, RoutedEventArgs e) => startWindow.WindowState = WindowState.Minimized;
       
        /// <summary>
        /// Выход из учётной записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnExitZapic_Click(object sender, RoutedEventArgs e) => NavigationManager.ExitWindow(startWindow, new AuthorizationWindow());
       

        /// <summary>
        /// Отображает информацию пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e) => TextBlockVivod.UserInfo(tbName, tbSyrName, tbRole, Char1NameAndSurName);


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
        /// Кнопка открывает мои книги выданные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyBooks_Click(object sender, RoutedEventArgs e) => startFrame.Navigate(new MyBookPage());          
       

        /// <summary>
        /// Стартовая страница
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMain_Click(object sender, RoutedEventArgs e) => startFrame.Navigate(new MainPage());
       
        /// <summary>
        /// Страница книг
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBooks_Click(object sender, RoutedEventArgs e) => startFrame.Navigate(new BookPage());
       


        /// <summary>
        /// Страница с редактирование логином и паролем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditUser_Click(object sender, RoutedEventArgs e) => startFrame.Navigate(new EditUserPage());
       
        private void startWindow_Loaded(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame = startFrame;
            startFrame.Navigate(new MainPage());
        }

        /// <summary>
        /// Кнопка с помощью
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSapport_Click(object sender, RoutedEventArgs e) => NavigationManager.StartFrame.Navigate(new SupportPage());
       
    }
}
