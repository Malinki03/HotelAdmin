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
    
    public partial class tipusBalco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipusBalco()
        {
            this.tipusHabs = new HashSet<tipusHab>();
        }
    
        public string tipusBalco1 { get; set; }
        public string nomTipusBalco { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tipusHab> tipusHabs { get; set; }
    }
}
