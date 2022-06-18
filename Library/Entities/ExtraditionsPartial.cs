using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public partial class Extraditions
    {
        public string TypeUsers       
        {

           get
           {
                if (Id > 0)
                {
                    var typeUsers = "";

                    if (IdSchoolBoy != null)
                    {                                              
                       typeUsers =  "Ученик";
                    }

                    if (IdTeachers != null)
                    {

                        typeUsers = "Учитель";
                    }                    
                    return typeUsers;

                }

                else
                {
                    return TypeUsers;
                }

            }
        } 
        
        
       
        public static string NamberClasses { get; set; }

        public string FullName
        {
            get
            {
                if (Id > 0)
                {
                    var fullName = "";

                    if (IdSchoolBoy != null)
                    {
                       NamberClasses = $"{SchoolBoy.Classes.Number} {SchoolBoy.Classes.ClassTheLetters.Letters}";
                       fullName = $"{SchoolBoy.SurName} {SchoolBoy.Name} {NamberClasses}";
                       
                    }

                    if (IdTeachers != null)
                    {
                        NamberClasses = $"{Teachers.Classes.Number} {Teachers.Classes.ClassTheLetters.Letters}";
                        fullName = $"{Teachers.SurName} {Teachers.Name} {NamberClasses}";
                       
                    }

                    

                    return fullName;
                   
                }

                else
                {
                    return FullName;
                }
            }
        }
    }
}
