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
    
    public partial class habitacio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public habitacio()
        {
            this.habitacioDias = new HashSet<habitacioDia>();
        }
    
        public string numero { get; set; }
        public int TipusHab_codi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<habitacioDia> habitacioDias { get; set; }
        public virtual tipusHab tipusHab { get; set; }
    }
}
