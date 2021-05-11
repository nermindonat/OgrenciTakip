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

        public void Ekle(DataAccess.OgrBilgi ogrBilgi)
        {
            Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();

            var ogrenci = entities.OgrBilgi.Where(p => p.OgrNo == ogrBilgi.OgrNo).ToList();

            if (ogrenci.Count==0)
            {
                entities.OgrBilgi.Add(ogrBilgi);
                entities.SaveChanges();

            }           
        }

        public List<Proje.DataAccess.OgrBilgi> OgrenciAra(int ogrNo)
        {
            Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();

            var ogrenci = entities.OgrBilgi.Where(p => p.OgrNo == ogrNo).ToList();
            return ogrenci;


        }
    }
}
