//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Extraditions
    {
        public int Id { get; set; }
        public Nullable<int> IdSchoolBoy { get; set; }
        public System.DateTime DateOfISsue { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<int> IdClasses { get; set; }
        public Nullable<int> IdBook { get; set; }
        public Nullable<int> IdTeachers { get; set; }
        public Nullable<int> IdTypeOfHalls { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Classes Classes { get; set; }
        public virtual Teachers Teachers { get; set; }
        public virtual TypeOfHalls TypeOfHalls { get; set; }
        public virtual SchoolBoy SchoolBoy { get; set; }
    }
}
