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
        public string Adres { get; set; }


        public List<Proje.DataAccess.OgrBilgi> OgrenciBilgi(int ogrId)
        {
            Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();
            Proje.DataAccess.OgrBilgi ogrBilgi = new Proje.DataAccess.OgrBilgi();

            var liste = entities.OgrBilgi.Where(p => p.OgrBilgiId == ogrId).ToList();
            return liste;
        }

        public void Ekle(OgrBilgi ogrBilgi)
        {
            Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();
            Proje.DataAccess.OgrBilgi ogrenci = new Proje.DataAccess.OgrBilgi();

            entities.OgrBilgi.Add(ogrenci);
            entities.SaveChanges();
        }
    }
}
