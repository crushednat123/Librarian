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
using FontAwesome.Sharp;
using System.Windows.Controls.Primitives;
using Library.Pages.PageTeacher.PagesTeachers.Pages;
using Library.Pages.PageLibrarian.Pages.EditingPages;

namespace Library.Pages.PageLibrarian.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserDatePage.xaml
    /// </summary>
    public partial class UserDatePage : Page
    {       
        public static int shoolId  { get; set;}
        public static int shoolDeleteId = -1;

        public static int techersId { get; set; }
        public static int techersDeleteId = -1;

        public static int librarianId { get; set; }
        public static int librarianDeleteId = -1;
        
        public UserDatePage()
        {
           InitializeComponent();         
           AddHandler(KeyDownEvent, (KeyEventHandler)btnApdateAllDate_KeyDown, true);                     
        }

        /// <summary>
        /// Заполняет ListView данными
        /// </summary>
        public  void ListDate()
        {           
            // если грид библиотекаря отображен
            if (gridLibrarian.Visibility == Visibility.Visible)
            {
                tbInfoLibrarian.Visibility = Visibility.Collapsed;
                listLibrarian.ItemsSource = App.DataBase.Users.Where(p=> p.IdLibrarian != null && p.Login != DateUser.Login).ToList();               
            }

            // если грид школьника отображен
            if (gridShoolBoy.Visibility == Visibility.Visible)
            {
                var sqlSchool = "DECLARE @PageNumber AS INT, @RowspPage AS INT" +
                 $" SET @PageNumber = {GlobalVariabls.shool}" +
                 $" SET @RowspPage = {GlobalVariabls.countRow}" +
                 " SELECT* " +
                 " FROM Users, SchoolBoy" +
                 " Where Users.IdSchool not in ('')" +
                 " ORDER BY SchoolBoy.SurName " +
                 " OFFSET((@PageNumber - 1) * @RowspPage) ROWS " +
                 " FETCH NEXT @RowspPage ROWS ONLY;";

                 listShoolBoy.ItemsSource = App.DataBase.Users.SqlQuery(sqlSchool).ToList();
                 tbInfo.Visibility = Visibility.Collapsed;
            }


            // если грид учителя отображен
            if (gridTeashers.Visibility == Visibility.Visible)
            {
                var sqlTeachers = "DECLARE @PageNumber AS INT, @RowspPage AS INT" +
                                $" SET @PageNumber = {GlobalVariabls.techers}" +
                                $" SET @RowspPage = {GlobalVariabls.countRow}" +
                                " SELECT *" +
                                " FROM Users,  Teachers" +
                                " WHERE Users.IdTeachers NOT IN('')" +
                                " ORDER BY Teachers.SurName" +
                                " OFFSET((@PageNumber - 1) * @RowspPage) ROWS" +
                                " FETCH NEXT @RowspPage ROWS ONLY;";
                
                listTechers.ItemsSource = App.DataBase.Users.SqlQuery(sqlTeachers).ToList();                
            }
        }
       

        public  void Search()
        {
            // если грид библиотекаря отображен
            if (gridLibrarian.Visibility == Visibility.Visible)
            {
                if (!string.IsNullOrEmpty(tbPoiskSLiabrarian.Text))
                {
                    try
                    {
                        listLibrarian.ItemsSource = App.DataBase.Users.ToList().Where(p => (p.IdLibrarian != null) &&
                        (p.Librarian.Name.ToString().ToLower().Contains(tbPoiskSLiabrarian.Text.ToLower()) ||
                        p.Librarian.SurName.ToString().ToLower().Contains(tbPoiskSLiabrarian.Text.ToLower()) ||
                        p.Librarian.Address.ToString().ToLower().Contains(tbPoiskSLiabrarian.Text.ToLower()) ||
                        p.Login.ToString().ToLower().Contains(tbPoiskSLiabrarian.Text.ToLower())))
                        .OrderBy(p => p.Librarian.SurName).ToList();

                        var rows = listLibrarian.ItemsSource.Cast<Users>().ToList();
                        if (rows.Count == 0)
                        {
                            tbInfoLibrarian.Visibility = Visibility.Visible;
                        }
                        if (rows.Count != 0)
                        {
                            tbInfoLibrarian.Visibility = Visibility.Collapsed;
                        }

                    }
                    catch
                    {
                        tbInfoLibrarian.Visibility = Visibility.Collapsed;
                        MessageBox.Show("Ошибка в получении данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    try
                    {                       
                        ListDate();
                    }
                    catch
                    {
                        tbInfoLibrarian.Visibility = Visibility.Collapsed;
                        MessageBox.Show("Ошибка в получении данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }

            // если грид школьника отображен
            if (gridShoolBoy.Visibility == Visibility.Visible)
            {
                if (!string.IsNullOrEmpty(tbPoiskShoolBoy.Text))
                {
                    try
                    {
                        listShoolBoy.ItemsSource = App.DataBase.Users.ToList().Where(p => (p.IdSchool != null) &&
                        (p.SchoolBoy.Name.ToString().ToLower().Contains(tbPoiskShoolBoy.Text.ToLower()) ||
                        p.SchoolBoy.SurName.ToString().ToLower().Contains(tbPoiskShoolBoy.Text.ToLower()) ||
                        p.SchoolBoy.Address.ToString().ToLower().Contains(tbPoiskShoolBoy.Text.ToLower()) ||
                        p.Login.ToString().ToLower().Contains(tbPoiskShoolBoy.Text.ToLower())))
                        .OrderBy(p => p.SchoolBoy.SurName).ToList();

                        var rows = listShoolBoy.ItemsSource.Cast<Users>().ToList();
                        if (rows.Count == 0)
                        {
                            tbInfo.Visibility = Visibility.Visible;
                        }
                        if (rows.Count != 0)
                        {
                            tbInfo.Visibility = Visibility.Collapsed;
                        }

                    }
                    catch
                    {
                        tbInfo.Visibility = Visibility.Collapsed;
                        MessageBox.Show("Ошибка в получении данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    try
                    {                       
                        ListDate();
                    }
                    catch
                    {
                        tbInfo.Visibility = Visibility.Collapsed;
                        MessageBox.Show("Ошибка в получении данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

            }


            // если грид учителя отображен
            if (gridTeashers.Visibility == Visibility.Visible)
            {
                if (!string.IsNullOrEmpty(tbPoiskSTeachers.Text))
                {
                    try
                    {
                        listTechers.ItemsSource = App.DataBase.Users.ToList().Where(p => (p.IdTeachers != null) &&
                        (p.Teachers.Name.ToString().ToLower().Contains(tbPoiskSTeachers.Text.ToLower()) ||
                        p.Teachers.SurName.ToString().ToLower().Contains(tbPoiskSTeachers.Text.ToLower()) ||
                        p.Teachers.Address.ToString().ToLower().Contains(tbPoiskSTeachers.Text.ToLower()) ||
                        p.Login.ToString().ToLower().Contains(tbPoiskSTeachers.Text.ToLower())))
                        .OrderBy(p => p.Teachers.SurName).ToList();

                        var rows = listTechers.ItemsSource.Cast<Users>().ToList();
                        if (rows.Count == 0)
                        {
                            tbInfotext.Visibility = Visibility.Visible;
                        }
                        if (rows.Count != 0)
                        {
                            tbInfotext.Visibility = Visibility.Collapsed;
                        }

                    }
                    catch
                    {
                        tbInfotext.Visibility = Visibility.Collapsed;
                        MessageBox.Show("Ошибка в получении данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    try
                    {
                        tbInfotext.Visibility = Visibility.Collapsed;
                        ListDate();
                    }
                    catch
                    {
                        tbInfotext.Visibility = Visibility.Collapsed;
                        MessageBox.Show("Ошибка в получении данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Отображает данные, взаимозависимости какой тип пользователя выбрал библиотекарь
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageContent_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (GlobalVariabls.UserType == 2)
            {
                gridLibrarian.Visibility = Visibility.Visible;
            }

            if (GlobalVariabls.UserType == 4)
            {
                gridShoolBoy.Visibility = Visibility.Visible;
            }

            if (GlobalVariabls.UserType == 3)
            {
                gridTeashers.Visibility = Visibility.Visible;
            }

            if (NavigationManager.ApdateCheck == "3")
            {
                LoadData();
            }
        }

        /// <summary>
        /// Прокручивает ползунок, даже если мышка не наведена на него
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e) =>
            ScrollWiewers.ScrollWiewerContentScroll(sender, e);

        // получение айдишника пользователей
        private void listIdAll_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(gridShoolBoy.Visibility == Visibility.Visible)
            {
               DateUser.IdCheck(shoolId, shoolDeleteId, listShoolBoy, borderImageShol, 4);               
            }
            if (gridTeashers.Visibility == Visibility.Visible)
            {
               DateUser.IdCheck(techersId, techersDeleteId, listTechers, borderImageTeachers, 3);               
            }

            if (gridLibrarian.Visibility == Visibility.Visible)
            {
                DateUser.IdCheck(librarianId, librarianDeleteId, listLibrarian, borderImageLibrarian,2);
            }
        }
    
        /// <summary>
        /// Открывает изображение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageAll_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(gridShoolBoy.Visibility == Visibility.Visible)
            {
                ImageVisible.VisibleImage(btnApdateAllDate, borderImageShol, btnPoiskShoolBoy, btnDeleteShoolBoy, btnAdShoolBoy, 1);
            }

            if (gridLibrarian.Visibility == Visibility.Visible)
            {
                ImageVisible.VisibleImage(btnApdateAllDate, borderImageLibrarian, btnPoiskLibrarian, btnDeleteLibrarian, btnAdLibrarian, 1);
            }
            if (gridTeashers.Visibility == Visibility.Visible)
            {
                ImageVisible.VisibleImage(btnApdateAllDate, borderImageTeachers, btnPoiskTeachers, btnDeleteTeachers, btnAdTeachers, 1);
            }
           
        }

      

        /// <summary>
        /// Скрывает отображенную картинку 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorderCollapsed_Click(object sender, RoutedEventArgs e)
        {
            if(gridShoolBoy.Visibility == Visibility.Visible)
            {
                ImageVisible.VisibleImage(btnApdateAllDate, borderImageShol, btnPoiskShoolBoy, btnDeleteShoolBoy, btnAdShoolBoy, 0);               
            }

            if (gridTeashers.Visibility == Visibility.Visible)
            {
                ImageVisible.VisibleImage(btnApdateAllDate, borderImageTeachers, btnPoiskTeachers, btnDeleteTeachers, btnAdTeachers,0);               
            }

            if (gridLibrarian.Visibility == Visibility.Visible)
            {
                ImageVisible.VisibleImage(btnApdateAllDate, borderImageLibrarian, btnPoiskLibrarian, btnDeleteLibrarian, btnAdLibrarian, 0);
            }          
        }
       

        /// <summary>
        /// Кнопка редактировать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditAll_Click(object sender, RoutedEventArgs e)
        {            
            if (gridLibrarian.Visibility == Visibility.Visible)
            {
                NavigationManager.StartFrame.Navigate(new EditAdLibrarianPage((sender as Button).DataContext as Users));
            }

            if (gridShoolBoy.Visibility == Visibility.Visible)
            {
                NavigationManager.StartFrame.Navigate(new EditMyCkassesPage((sender as Button).DataContext as Users));
            }

            if (gridTeashers.Visibility == Visibility.Visible)
            {
                NavigationManager.StartFrame.Navigate(new EditTeachersPage((sender as Button).DataContext as Users));
            }

            NavigationManager.ApdateCheck = "1";            
        }

        /// <summary>
        /// Кнопка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPoisk_Click(object sender, RoutedEventArgs e) => Search();


        /// <summary>
        /// Если текстовое поле пустое, то возвращаются все данные в сходное положение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPoisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (gridShoolBoy.Visibility == Visibility.Visible)
            {
                if (tbPoiskShoolBoy.Text == "")
                {
                    ListDate();                   
                }
            }

            if (gridTeashers.Visibility == Visibility.Visible)
            {
                if (tbPoiskSTeachers.Text == "")
                {
                    tbInfotext.Visibility = Visibility.Collapsed;
                    ListDate();
                }
            }

            if (gridLibrarian.Visibility == Visibility.Visible)
            {
                if (tbPoiskSLiabrarian.Text == "")
                {
                    ListDate();
                }
            }

        }
      
        /// <summary>
        /// Кнопка добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdAll_Click(object sender, RoutedEventArgs e)
        {
            if (gridTeashers.Visibility == Visibility.Visible)
            {
                NavigationManager.StartFrame.Navigate(new EditTeachersPage(null));
            }
            if (gridShoolBoy.Visibility == Visibility.Visible)
            {
                NavigationManager.StartFrame.Navigate(new EditMyCkassesPage(null));
            }
            if (gridLibrarian.Visibility == Visibility.Visible)
            {
                NavigationManager.StartFrame.Navigate(new EditAdLibrarianPage(null));
            }
            NavigationManager.ApdateCheck = "2";           
        }


        /// <summary>
        /// Кнопка удаления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAll_Click(object sender, RoutedEventArgs e)
        {           
            if(gridShoolBoy.Visibility == Visibility.Visible)
            {
                MessageBoxResult mesBoxRes = MessageBox.Show("Вы точно хотите удалить этого ученика?", "Внимание",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
                if (mesBoxRes == MessageBoxResult.Yes)
                {
                    try
                    {
                        shoolDeleteId = (int)(listShoolBoy.SelectedItem as Users).IdSchool;

                        var sql = "Select * From Extraditions" +
                                  $" Where IdSchoolBoy = {shoolDeleteId}";

                        var deletSchool = "DELETE SchoolBoy" +
                                          $" WHERE Id = {shoolDeleteId}";

                        var check = App.DataBase.Extraditions.SqlQuery(sql).ToArray();

                        if (check.Length != 0)
                        {
                            MessageBox.Show("Ученик ещё не сдал все книги");
                        }
                        if (check.Length == 0)
                        {
                            var delete = App.DataBase.Database.ExecuteSqlCommand(deletSchool);
                            App.DataBase.SaveChanges();

                            MessageBox.Show("Данные удалены!", "", MessageBoxButton.OK, MessageBoxImage.Information);
                            ListDate();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            if (gridTeashers.Visibility == Visibility.Visible)
            {
               MessageBoxResult mesBoxRes = MessageBox.Show("Вы точно хотите удалить данного учителя", "Внимание",
               MessageBoxButton.YesNo,
               MessageBoxImage.Question);
                if (mesBoxRes == MessageBoxResult.Yes)
                {
                    try
                    {
                        techersDeleteId = (int)(listTechers.SelectedItem as Users).IdTeachers;

                        var sql = "Select * From Extraditions" +
                                  $" Where IdTeachers = {techersDeleteId}";

                        var deletTeachers = "DELETE Teachers" +
                                          $" WHERE Id = {techersDeleteId}";

                        var check = App.DataBase.Extraditions.SqlQuery(sql).ToArray();

                        if (check.Length != 0)
                        {
                            MessageBox.Show("Учитель ещё не сдал все книги");
                        }
                        if (check.Length == 0)
                        {
                            var delete = App.DataBase.Database.ExecuteSqlCommand(deletTeachers);
                            App.DataBase.SaveChanges();

                            MessageBox.Show("Данные удалены!", "", MessageBoxButton.OK, MessageBoxImage.Information);
                            ListDate();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            if (gridLibrarian.Visibility == Visibility.Visible)
            {
                MessageBoxResult mesBoxRes = MessageBox.Show("Вы точно хотите удалить этого библиотекаря?", "Внимание",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
                if (mesBoxRes == MessageBoxResult.Yes)
                {
                    try
                    {
                        librarianDeleteId = (int)(listLibrarian.SelectedItem as Users).IdLibrarian;
                       
                        var deletLibrarian = "DELETE Librarian" +
                                          $" WHERE Id = {librarianDeleteId}";
                                                                    
                            var delete = App.DataBase.Database.ExecuteSqlCommand(deletLibrarian);
                            App.DataBase.SaveChanges();

                            MessageBox.Show("Данные удалены!", "", MessageBoxButton.OK, MessageBoxImage.Information);
                            ListDate();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
                       
        }
       
        /// <summary>
        /// Отображает контент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageContent_Loaded(object sender, RoutedEventArgs e)
        {
            // что бы при открытии страницы повторно (переменные сбрасывались)
            // зачем ?  Что бы список выводимый был от первой записи, а не от то которой ListView последний раз запомнил
            if(pageContent.Visibility == Visibility.Visible)
            {
                if(GlobalVariabls.shool != 1)
                {
                   GlobalVariabls.shool = 1;
                }
                if(GlobalVariabls.techers != 1)
                {
                   GlobalVariabls.techers = 1;
                }
               
                if (GlobalVariabls.countRow != 10)
                {
                    GlobalVariabls.countRow = 10;
                }
            }
            if (gridShoolBoy.Visibility == Visibility.Visible)
            {
                listShoolBoy.Focus();
                tButtonSchool10.IsChecked = true;
                tButtonSchool10.IsEnabled = false;
            }

            if (gridTeashers.Visibility == Visibility.Visible)
            {
                listTechers.Focus();               
            }

            if (gridLibrarian.Visibility == Visibility.Visible)
            {
                listTechers.Focus();
            }

            ButtonStyles.ButtunDafault(pageMinysSchool, iconMinysSchool);
            ButtonStyles.ButtunDafault(pageMinysTesters, iconMinysTechers);
            
            ListDate();
        }

        /// <summary>
        /// Возвращает предыдущие данные у учителей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void pageMinysTesters_Click(object sender, RoutedEventArgs e) =>        
            ButtonPlusAndMinys(ref GlobalVariabls.techers, pageMinysTesters, iconMinysTechers, -1);
            
        
        

        /// <summary>
        /// Меняет данные вперёд у учителей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pagePlusTesters_Click(object sender, RoutedEventArgs e) =>        
            ButtonPlusAndMinys(ref GlobalVariabls.techers, pageMinysTesters, iconMinysTechers, 1);

                  
        /// <summary>
        /// Обновляет данные
        /// </summary>
        private void LoadData()
        {
            App.DataBase.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            ListDate();
        }

        /// <summary>
        /// Кнопка обновления, которая работает при нажатии клавиши F5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApdateAllDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                LoadData();
            }
        }

        /// <summary>
        /// листает данные школьников назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageMinysSchool_Click(object sender, RoutedEventArgs e) =>
            ButtonPlusAndMinys(ref GlobalVariabls.shool, pageMinysSchool, iconMinysSchool, -1);



        /// <summary>
        /// листает данные школьников вперёд
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pagePlusSchool_Click(object sender, RoutedEventArgs e) =>
            ButtonPlusAndMinys(ref GlobalVariabls.shool, pageMinysSchool, iconMinysSchool, 1);
       
        /// <summary>
        /// Меняет количество строк
        /// </summary>
        /// <param name="toggleButton1"></param>
        /// <param name="toggleButton2"></param>
        /// <param name="toggleButton3"></param>
        /// <param name="rowСount"></param>
        public void NumberOfRows(ToggleButton toggleButton1, ToggleButton toggleButton2,
                                 ToggleButton toggleButton3, int rowСount)
        {
            if (toggleButton1.IsChecked == true)
            {
                toggleButton1.IsEnabled = false;
                if (toggleButton2 != null && toggleButton3 != null)
                {
                    toggleButton2.IsChecked = false;
                    toggleButton3.IsChecked = false;                    
                    toggleButton2.IsEnabled = true;
                    toggleButton3.IsEnabled = true;
                }                              
                GlobalVariabls.countRow  = rowСount;
            }          
            ListDate();
        }

        /// <summary>
        /// Меняет  количество строк у школьников 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tButtonSchool10_Click(object sender, RoutedEventArgs e) =>
            NumberOfRows(tButtonSchool10, tButtonSchool50, tButtonSchool100, 10);


        /// <summary>
        /// Меняет  количество строк у школьников 50
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tButtonSchool50_Click(object sender, RoutedEventArgs e) =>
            NumberOfRows(tButtonSchool50, tButtonSchool10, tButtonSchool100, 50);


        /// <summary>
        /// Меняет  количество строк у школьников 100
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tButtonSchool100_Click(object sender, RoutedEventArgs e) =>
            NumberOfRows(tButtonSchool100, tButtonSchool50, tButtonSchool10, 100);



        /// <summary>
        /// Отключает в нужный момент кнопку, и меняет переменную для отображения следующей или прошлой страницы
        /// </summary>
        /// <param name="typePage"></param>
        /// <param name="buttonMinys"></param>
        /// <param name="iconMinys"></param>
        /// <param name="typeButton"></param>
        public  void ButtonPlusAndMinys(ref int typePage, Button buttonMinys,
                                        IconImage iconMinys, int typeButton)
        {
            if (typeButton == 1)
            {
                typePage += 1;

                if (typePage == 1)
                {
                    buttonMinys.IsEnabled = false;
                    iconMinys.Foreground = Brushes.Gray;
                    ListDate();
                }

                if (typePage != 1)
                {
                    buttonMinys.IsEnabled = true;
                    SolidColorBrush brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6673b7"));
                    iconMinys.Foreground = brush;
                    ListDate();
                }
            }

            if (typeButton == -1)
            {
                if (typePage == 1)
                {
                    buttonMinys.IsEnabled = false;
                    iconMinys.Foreground = Brushes.Gray;
                }

                if (typePage != 1)
                {
                    buttonMinys.IsEnabled = true;
                    typePage -= 1;
                    ListDate();

                    if (typePage == 1)
                    {
                        buttonMinys.IsEnabled = false;
                        iconMinys.Foreground = Brushes.Gray;
                    }
                }
            }
        }       
    }
}
