//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bildirimler
    {
        public int BildirimId { get; set; }
        public int FkOgrBilgiId { get; set; }
        public int FkNotId { get; set; }
        public int FkDevamsizlikId { get; set; }
        public string Icerik { get; set; }
        public Nullable<System.DateTime> BildirimTarih { get; set; }
    
        public virtual DevamsizlikBilgi DevamsizlikBilgi { get; set; }
        public virtual Notlar Notlar { get; set; }
        public virtual OgrBilgi OgrBilgi { get; set; }
    }
}
