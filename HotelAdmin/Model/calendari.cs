//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelAdmin.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class calendari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public calendari()
        {
            this.costaDias = new HashSet<costaDia>();
            this.habitacioDias = new HashSet<habitacioDia>();
        }
    
        public System.DateTime data { get; set; }
        public Nullable<short> esFestiu { get; set; }
        public int Tarifa_codi { get; set; }
    
        public virtual tarifa tarifa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<costaDia> costaDias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<habitacioDia> habitacioDias { get; set; }
    }
}
