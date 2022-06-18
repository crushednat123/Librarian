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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library.Pages.PageLibrarian.Pages.EditingPages
{
    /// <summary>
    /// Логика взаимодействия для EditOutputPage.xaml
    /// </summary>
    public partial class EditOutputPage : Page
    {
        private Extraditions _currentExtradition = new Extraditions();

        public EditOutputPage(Extraditions selectExtraditin)
        {
            InitializeComponent();

            if (selectExtraditin != null)
            {
                _currentExtradition = selectExtraditin;
            }

            DataContext = _currentExtradition;

            cbShoolBoy.ItemsSource = App.DataBase.SchoolBoy.OrderBy(p => p.SurName).ToList();
            cbTeachers.ItemsSource = App.DataBase.Teachers.OrderBy(p => p.SurName).ToList();
            cbClass.ItemsSource = App.DataBase.Classes.ToList();
        }


        /// <summary>
        /// Отключает контролы, при редактировании 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (NavigationManager.TypeBattun == 1)
            {
                cbBook.ItemsSource = App.DataBase.Books.OrderBy(p => p.NameBook).ToList();
                cbBook.IsEnabled = false;
                cbShoolBoy.IsEnabled = false;
                cbTeachers.IsEnabled = false;
                radioSchool.IsEnabled = false;
                cbClass.IsEnabled = false;
                radioTeachers.IsEnabled = false;
            }

            if (NavigationManager.TypeBattun == 0)
            {
                cbBook.ItemsSource = App.DataBase.Books.Where(p => p.IdBookLocation != 3).OrderBy(p => p.NameBook).ToList();
                cbBook.IsEnabled = true;
                cbShoolBoy.IsEnabled = false;
                cbTeachers.IsEnabled = false;
                cbClass.IsEnabled = true;
                radioSchool.IsEnabled = true;
                radioTeachers.IsEnabled = true;

            }
        }

        /// <summary>
        /// Кнопка сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();

            if (_currentExtradition.Classes == null)
            {
                error.AppendLine("\nВыберите класс");
            }

            if (cbShoolBoy.Text == "" && cbTeachers.Text == "")
            {
                error.AppendLine("\nВыберите ученика или учителя");
            }

            if (_currentExtradition.Books == null)
            {
                error.AppendLine("\nВыберите книгу");
            }

            if (_currentExtradition.DateOfISsue == null)
            {
                error.AppendLine("\nУкажите дату выдачи");
            }

            if (_currentExtradition.EndDate == null)
            {
                error.AppendLine("\nУкажите дату окончания выдачи");
            }

            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (_currentExtradition.Id != 0)
            {
                try
                {
                    NavigationManager.SaveDate("1");
                }
                catch
                {
                    MessagesInfo.ErrorServer();
                }
            }

            if (_currentExtradition.Id == 0)
            {
                try
                {
                    _currentExtradition.IdTypeOfHalls = 3;
                    App.DataBase.Extraditions.Add(_currentExtradition);
                    if (cbShoolBoy.IsEnabled == true)
                    {
                        AdHistoriExtradition(cbShoolBoy, 1, dpDateVidaha, dpDateOkonhania, cbClass, tbNameBook , tbNamberBook);
                    }
                    if (cbTeachers.IsEnabled == true)
                    {
                        AdHistoriExtradition(cbTeachers, 2, dpDateVidaha, dpDateOkonhania, cbClass, tbNameBook, tbNamberBook);
                    }
                    var sqlBook = $"Update Books Set IdBookLocation = 3 Where Id = {tbIdBook.Text}";
                    var update = App.DataBase.Database.ExecuteSqlCommand(sqlBook);
                    NavigationManager.SaveDate("1");
                }
                catch
                {
                    MessagesInfo.ErrorServer();
                }
            }
        }


        /// <summary>
       /// Добавление данных в историю выдачи
       /// </summary>
       /// <param name="users"></param>
       /// <param name="typeUsers"></param>
       /// <param name="dateOfSsue"></param>
       /// <param name="endDate"></param>
       /// <param name="classes"></param>
       /// <param name="book"></param>
       /// <param name="namberBook"></param>
        public void AdHistoriExtradition(ComboBox users, int typeUsers,
            DatePicker dateOfSsue,  DatePicker  endDate, ComboBox classes, TextBlock book, TextBlock namberBook)
        {
            HistoriExtradition histori = new HistoriExtradition();

            histori.Users = users.Text;
            histori.TypeUsers = typeUsers;
            histori.EndDate = Convert.ToDateTime(endDate.Text);
            histori.DateOfISsue = Convert.ToDateTime(dateOfSsue.Text);
            histori.Class = classes.Text;
            histori.Book = book.Text;
            histori.NamberBook = Convert.ToInt32(namberBook.Text);
            try
            {
                App.DataBase.HistoriExtradition.Add(histori);
                App.DataBase.SaveChanges();
            }
            catch
            {
                MessagesInfo.ErrorServer();
            }           
        }

        /// <summary>
        /// Дата окончания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpDateOkonhania_CalendarOpened(object sender, RoutedEventArgs e) =>
            dpDateOkonhania.SelectedDate = DateTime.Now.Date;
      

        /// <summary>
        /// Дата выдачи
        /// </summary>
        /// <param name = "sender" ></param >
        /// <param name="e"></param>
        private void dpDateVidaha_CalendarOpened(object sender, RoutedEventArgs e) =>
            dpDateVidaha.SelectedDate = DateTime.Now.Date;


        /// <summary>
        /// Включает нужный список пользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioAll_Click(object sender, RoutedEventArgs e)
        {
           

            if (radioSchool.IsChecked == true)
            {
                if (cbTeachers.Text != "")
                {
                    cbTeachers.Text = null;
                }
                cbShoolBoy.IsEnabled = true;
                cbTeachers.IsEnabled = false;

                tbLoginCheckUsers.Text = "";

                if (tbLoginCheckUsers.Text.Length == 0)
                {
                    textBlockText.Text = "Логин";
                }
            }

            if (radioTeachers.IsChecked == true)
            {
                if (cbShoolBoy.Text != "")
                {
                    cbShoolBoy.Text = null;
                }

                cbShoolBoy.IsEnabled = false;
                cbTeachers.IsEnabled = true;

                tbLoginCheckUsers.Text = "";

                if (tbLoginCheckUsers.Text.Length == 0)
                {
                    textBlockText.Text = "Логин";
                }
            }            
        }

        /// <summary>
        /// Получение айдишника школьника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbShoolBoy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {          
            try
            {
                if (cbShoolBoy.SelectedItem !=null)
                {
                    int id = (cbShoolBoy.SelectedItem as SchoolBoy).Id;
                  
                    var login = App.DataBase.Users.Where(p =>
                    p.IdSchool == id).Select(p => p.Login).FirstOrDefault();

                    tbLoginCheckUsers.Text = login;
                }
                if (tbLoginCheckUsers.Text.Length != 0)
                {
                    textBlockText.Text = "";
                }              
            }
            catch 
            {
                MessagesInfo.ErrorServer();
            }
           
        }

        /// <summary>
        /// Получение айдишника учителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTeachers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {          
            try
            {
                if (cbTeachers.SelectedItem != null)
                {
                    int id = (cbTeachers.SelectedItem as Teachers).Id;
                   
                    var login = App.DataBase.Users.Where(p=> 
                    p.IdTeachers == id).Select(p=> p.Login).FirstOrDefault();

                    tbLoginCheckUsers.Text = login;
                }

                if (tbLoginCheckUsers.Text.Length != 0)
                {
                    textBlockText.Text = "";
                }              
            }
            catch
            {

                MessagesInfo.ErrorServer();
            }
        }



    }
}
