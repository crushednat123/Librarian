using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Library.Entities;

namespace Library.Logic
{
    public class DateUser
    {
        public static string Name { get; set; }
        public static string SurName { get; set; }
        public static string Id { get; set; }
        public static string IdRole { get; set; }

        public static string IdCinderCode;


        public static string IdBook { get; set; }
        public static string Login { get; set; }
        public static string IdClasses { get; set; }


        /// <summary>
        /// Получение айдишника пользователя
        /// </summary>
        /// <param name="idUsers"></param>
        /// <param name="idDelete"></param>
        /// <param name="listName"></param>
        /// <param name="borderName"></param>
        /// <param name="typeUsers"></param>
        public static void IdCheck(int idUsers, int idDelete, ListView listName, Border borderName, byte typeUsers)
        {
            try
            {
                if (idUsers == idDelete)
                {
                    idUsers = 0;
                }
                else
                {
                    if (listName.SelectedItem != null)
                    {
                        // библиотекарь
                        if (typeUsers == 2)
                        {
                            idUsers = (int)(listName.SelectedItem as Users).IdLibrarian;
                            idDelete = -1;
                            borderName.DataContext = App.DataBase.Librarian.Where(p => p.Id == idUsers).ToList();
                        }

                        // учитель
                        if (typeUsers == 3)
                        {
                            idUsers = (int)(listName.SelectedItem as Users).IdTeachers;
                            idDelete = -1;
                            borderName.DataContext = App.DataBase.Teachers.Where(p => p.Id == idUsers).ToList();
                        }

                        // ученик
                        if (typeUsers == 4)
                        {
                            idUsers = (int)(listName.SelectedItem as Users).IdSchool;
                            idDelete = -1;
                            borderName.DataContext = App.DataBase.SchoolBoy.Where(p => p.Id == idUsers).ToList();
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
}
