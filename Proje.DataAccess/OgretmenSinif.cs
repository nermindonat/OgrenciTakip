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
    
    public partial class OgretmenSinif
    {
        public int OgrSinifId { get; set; }
        public int FkOgretmenId { get; set; }
        public int FkSinifId { get; set; }
    
        public virtual Ogretmenler Ogretmenler { get; set; }
        public virtual Siniflar Siniflar { get; set; }
    }
}
