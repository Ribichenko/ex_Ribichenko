//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ex_Ribichenko.AppDataFile
{
    using System;
    using System.Collections.Generic;
    
    public partial class member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public member()
        {
            this.@event = new HashSet<@event>();
        }
    
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string patronymic { get; set; }
        public string Email { get; set; }
        public System.DateTime birthday { get; set; }
        public int country { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public string photo { get; set; }
        public string gender { get; set; }
        public int id { get; set; }
        public Nullable<int> id_event { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<@event> @event { get; set; }
        public virtual @event event1 { get; set; }
    }
}