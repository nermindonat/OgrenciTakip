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
    
    public partial class Kullanicilar
    {
        public int KulId { get; set; }

        public object KullanicilariListele<T>()
        {
            throw new NotImplementedException();
        }

        public int FkKulTurId { get; set; }
        public int FkOgrId { get; set; }
        public int FkSinifId { get; set; }
        public string KulAd { get; set; }
        public string KulSoyad { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string Fotograf { get; set; }
        public int Yetki { get; set; }
    
        public virtual KullaniciTurleri KullaniciTurleri { get; set; }
        public virtual Siniflar Siniflar { get; set; }
    }
}
