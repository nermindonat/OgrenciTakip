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
    
    public partial class Notlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Notlar()
        {
            this.Bildirimler = new HashSet<Bildirimler>();
            this.Ogretmenler = new HashSet<Ogretmenler>();
        }
    
        public int NotId { get; set; }
        public int FkOgrBilgiId { get; set; }
        public Nullable<int> Sinav1 { get; set; }
        public Nullable<int> Sinav2 { get; set; }
        public Nullable<int> Performans { get; set; }
        public Nullable<int> Proje { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bildirimler> Bildirimler { get; set; }
        public virtual OgrBilgi OgrBilgi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ogretmenler> Ogretmenler { get; set; }
    }
}
