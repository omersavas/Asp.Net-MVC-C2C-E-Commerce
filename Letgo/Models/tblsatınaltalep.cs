//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Letgo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblsatınaltalep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblsatınaltalep()
        {
            this.tblsatınal = new HashSet<tblsatınal>();
        }
    
        public int talepID { get; set; }
        public Nullable<int> urunID { get; set; }
        public Nullable<int> kullanıcıID { get; set; }
        public Nullable<int> onaydurumu { get; set; }
        public Nullable<System.DateTime> taleptarihi { get; set; }
    
        public virtual tblkullanıcı tblkullanıcı { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblsatınal> tblsatınal { get; set; }
        public virtual tblurun tblurun { get; set; }
    }
}
