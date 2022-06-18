using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public partial class Teachers
    {
        public string FullName
        {
            get
            {
                if (Id > 0)
                {
                    var fullName = $"{Name} {SurName}";

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
                var classes = $"{Classes.Number}" + $"{Classes.ClassTheLetters.Letters}";

                return classes;              
            }
        }
      
    }
}
