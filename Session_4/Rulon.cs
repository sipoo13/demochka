//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Session_4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rulon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rulon()
        {
            this.Rulons_Products = new HashSet<Rulons_Products>();
        }
    
        public string Article { get; set; }
        public string Sostav { get; set; }
        public string Color { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rulons_Products> Rulons_Products { get; set; }
    }
}