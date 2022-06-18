using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public partial class Librarian
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
    }
}
