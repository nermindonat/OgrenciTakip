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
    
    public partial class OgrBilgi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OgrBilgi()
        {
            this.DevamsizlikBilgi = new HashSet<DevamsizlikBilgi>();
        }
    
        public int OgrBilgiId { get; set; }
        public int FkSinifId { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
        public Nullable<int> OgrNo { get; set; }
        public string Adres { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevamsizlikBilgi> DevamsizlikBilgi { get; set; }
        public virtual Siniflar Siniflar { get; set; }
    }
}
