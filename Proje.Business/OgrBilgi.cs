using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class OgrBilgi
    {
        public int FkSinifId { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
        public Nullable<int> OgrNo { get; set; }
        public Nullable<System.DateTime> DevamsizlikTarih { get; set; }
        public string DevamsizlikTur { get; set; }

        public List<Proje.DataAccess.OgrBilgi> OgrenciBilgi(int ogrId)
        {
            Proje.DataAccess.OgrenciTakipEntities1 entities = new Proje.DataAccess.OgrenciTakipEntities1();
            Proje.DataAccess.OgrBilgi ogrBilgi = new Proje.DataAccess.OgrBilgi();

            var liste = entities.OgrBilgi.Where(p => p.FkSinifId == ogrId).ToList();
            return liste;
        }

        public void Ekle(OgrBilgi ogrBilgi)
        {
            Proje.DataAccess.OgrenciTakipEntities1 entities = new Proje.DataAccess.OgrenciTakipEntities1();
            Proje.DataAccess.OgrBilgi ogrenci = new Proje.DataAccess.OgrBilgi();

            
        }
    }
}
