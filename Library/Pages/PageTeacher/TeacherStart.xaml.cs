using Library.Logic;
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
using Library.Pages.PageTeacher;
using Library.Pages.PageTeacher.PagesTeachers;
using Library.Pages.PageStudent.Pages;
using Library.Pages.PageTeacher.PagesTeachers.Pages;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Library.Pages.PageTeacher
{
    /// <summary>
    /// Логика взаимодействия для TeacherStart.xaml
    /// </summary>
    public partial class TeacherStart : Window
    {
        public TeacherStart()
        {
            InitializeComponent();                     
        }

        /// <summary>
        /// Отображает данные пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startWindowTeacher_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e) => TextBlockVivod.UserInfo(tbName, tbSyrName, tbRole, Char1NameAndSurName);           
       


        /// <summary>
        /// Страница с редактирование логином и паролем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditUser_Click(object sender, RoutedEventArgs e) => NavigationManager.StartFrame.Navigate(new PagesTeachers.Pages.EditUserPage());
       

        /// <summary>
        /// Стартовая страница
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMain_Click(object sender, RoutedEventArgs e) => NavigationManager.StartFrame.Navigate(new MainPagesTechers());
       

        /// <summary>
        /// Страница книги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBooks_Click(object sender, RoutedEventArgs e) => NavigationManager.StartFrame.Navigate(new BookPage());
       

        /// <summary>
        /// Страница мои книги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyBooks_Click(object sender, RoutedEventArgs e) => NavigationManager.StartFrame.Navigate(new PagesTeachers.Pages.MyBookPage());
        

        /// <summary>
        /// Страница мой класс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyClasses_Click(object sender, RoutedEventArgs e) => NavigationManager.StartFrame.Navigate(new MyClassesPage());
       
        
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
        private void btnExitZapic_Click(object sender, RoutedEventArgs e) => NavigationManager.ExitWindow(startWindowTeacher, new AuthorizationWindow());
        
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

            if (startFrame.Content.GetType().Name == "MainPagesTechers")
            {
                ButtonStyles.StyleButton(btnMain, btnMyBooks, btnBooks, btnExitZapic, btnMyClasses, null, 1);
                btnBack.Visibility = Visibility.Collapsed;
                startWindowTeacher.MinWidth = 775;
            }

            if (startFrame.Content.GetType().Name == "MyBookPage")
            {
                ButtonStyles.StyleButton(btnMyBooks, btnMain, btnBooks, btnExitZapic, btnMyClasses, null, 1);
                startWindowTeacher.MinWidth = 890;
            }

            if (startFrame.Content.GetType().Name == "BookPage")
            {
                ButtonStyles.StyleButton(btnBooks, btnMyBooks, btnMain, btnExitZapic, btnMyClasses, null, 1);
                startWindowTeacher.MinWidth = 805;
            }

            if (startFrame.Content.GetType().Name == "EditBookPage")
            {
                startWindowTeacher.MinHeight = 630;
            }

            if (startFrame.Content.GetType().Name == "MyClassesPage")
            {
                ButtonStyles.StyleButton(btnMyClasses,btnBooks, btnMyBooks, btnMain, btnExitZapic, null, 1);
                startWindowTeacher.MinWidth = 885;
            }

            if (startFrame.Content.GetType().Name == "EditUserPage")
            {
                ButtonStyles.StyleButton(btnBooks, btnMyBooks, btnMain, btnExitZapic, btnMyClasses, null, 0);
                startWindowTeacher.MinWidth = 805;
            }

            if (startFrame.Content.GetType().Name == "SupportPage")
            {
                startWindowTeacher.MinWidth = 970;
                ButtonStyles.StyleButton(btnBooks, btnMyBooks, btnMain, btnExitZapic, btnMyClasses, null, 0);
            }

        }



        /// <summary>
        /// Кнопка свернуть окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRollUp_Click(object sender, RoutedEventArgs e) => startWindowTeacher.WindowState = WindowState.Minimized;
       
        /// <summary>
        /// Закрывает программу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e) => MessagesInfo.MessagesExit();
       
        /// <summary>
        /// Кнопка расширить или уменьшить окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpand_Click(object sender, RoutedEventArgs e) => Expands.ExpandsWindow(startWindowTeacher, iconExpand, btnExpand);
        

        private void startWindowTeacher_Loaded(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame = startFrame;
            startFrame.Navigate(new MainPagesTechers());           
        }


        /// <summary>
        /// Кнопка с помощью
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSapport_Click(object sender, RoutedEventArgs e) => NavigationManager.StartFrame.Navigate(new SupportPage());
        
    }    
}
