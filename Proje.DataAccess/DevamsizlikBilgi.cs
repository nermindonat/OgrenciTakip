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
    
    public partial class DevamsizlikBilgi
    {
        public int DevamsizlikId { get; set; }
        public int FkOgrBilgiId { get; set; }
        public Nullable<System.DateTime> DevamsizlikTarih { get; set; }
        public string DevamsizlikTur { get; set; }
    
        public virtual OgrBilgi OgrBilgi { get; set; }
    }
}