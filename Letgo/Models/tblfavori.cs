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
    
    public partial class tblfavori
    {
        public int favoriID { get; set; }
        public Nullable<int> urunID { get; set; }
        public Nullable<int> KullanıcıID { get; set; }
    
        public virtual tblkullanıcı tblkullanıcı { get; set; }
        public virtual tblurun tblurun { get; set; }
    }
}
