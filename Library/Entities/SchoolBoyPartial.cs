using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public partial class SchoolBoy
    {
        
        public string FullName
        {
            get
            {
                if (Id > 0)
                {
                    var fullName = $"{SurName} {Name}";

                    return fullName;
                }

                else
                {
                    return FullName;
                }
            }
        }

        public string NamberClasses
        {
            get
            {
                if (Id > 0)
                {
                    var classes = "";

                    classes = $" {Classes.Number} {Classes.ClassTheLetters.Letters}";

                    return classes;

                }
                else
                {
                    return NamberClasses;
                }
            }
        }        
    }
}
