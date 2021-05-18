using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void Guncelle(DataAccess.OgrBilgi ogrBilgi)
        {
            Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();

            var ogrenci = entities.OgrBilgi.FirstOrDefault(p => p.OgrBilgiId == ogrBilgi.OgrBilgiId);
           
            if (ogrenci != null)
            {
                ogrenci.FkSinifId = ogrBilgi.FkSinifId;
                ogrenci.OgrAd = ogrBilgi.OgrAd;
                ogrenci.OgrSoyad = ogrBilgi.OgrSoyad;
                ogrenci.OgrNo = ogrBilgi.OgrNo;
                ogrenci.Adres = ogrBilgi.Adres;

                entities.OgrBilgi.Attach(ogrenci);
                entities.Entry(ogrenci).State = EntityState.Modified;
                entities.SaveChanges();
            }
        }

        public void Sil(int ogrBilgiId)
        {
            Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();
           
            var ogrenci = entities.OgrBilgi.FirstOrDefault(p => p.OgrBilgiId == ogrBilgiId);
            if(ogrenci != null)
            {
                entities.OgrBilgi.Remove(ogrenci);
                entities.SaveChanges();
            }
           
        }
    }
}
