using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public partial class Classes
    {
        public string NamberClasses
        {
            get
            {

                var classes = $"{Number} {ClassTheLetters.Letters}";

                return classes;
            }
        }
    }
}
