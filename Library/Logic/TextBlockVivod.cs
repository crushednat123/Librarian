using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Library.Logic
{
    public  class TextBlockVivod
    {
        /// <summary>
        /// Выводит ФИО, роль, и по одной букве от фамилии и имени 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surName"></param>
        /// <param name="role"></param>
        /// <param name="char1NamAndSurName"></param>
        public static void UserInfo(TextBlock name, TextBlock surName, TextBlock role, TextBlock char1NamAndSurName)
        {
            name.Text = DateUser.Name;
            surName.Text = DateUser.SurName;
            role.Text = DateUser.IdCinderCode;
            char1NamAndSurName.Text = DateUser.SurName.Substring(0, 1) + DateUser.Name.Substring(0, 1);
        }
    }
}
