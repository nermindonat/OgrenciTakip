using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class DevamsizlikBilgi
    {
        public int FkOgrBilgiId { get; set; }
        public Nullable<System.DateTime> DevamsizlikTarih { get; set; }
        public string DevamsizlikTur { get; set; }

        public List<Proje.DataAccess.DevamsizlikBilgi> DevamsizlikListele()
        {
            Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();
            Proje.DataAccess.DevamsizlikBilgi devamsizlikBilgi = new Proje.DataAccess.DevamsizlikBilgi();

            var devamBilgileri = entities.DevamsizlikBilgi.ToList();
            return devamBilgileri;
        }

        public void Ekle(DataAccess.DevamsizlikBilgi devamsizlikBilgi)
        {
            
            Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();
            Proje.DataAccess.DevamsizlikBilgi devamsizlik = new Proje.DataAccess.DevamsizlikBilgi();

            var ogrenci = entities.OgrBilgi.FirstOrDefault(x => x.OgrBilgiId == devamsizlikBilgi.FkOgrBilgiId);
            if(ogrenci != null)
            {
                entities.DevamsizlikBilgi.Add(devamsizlikBilgi);
                entities.SaveChanges();
            }
        }

        public void Guncelle(DataAccess.DevamsizlikBilgi devamsizlikBilgi)
        {
            Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();

            var ogrenci = entities.DevamsizlikBilgi.FirstOrDefault(d => d.DevamsizlikId == devamsizlikBilgi.DevamsizlikId);

            if (ogrenci != null)
            {
                ogrenci.FkOgrBilgiId = devamsizlikBilgi.FkOgrBilgiId;
                ogrenci.DevamsizlikTarih = devamsizlikBilgi.DevamsizlikTarih;
                ogrenci.DevamsizlikTur = devamsizlikBilgi.DevamsizlikTur;
                
                entities.DevamsizlikBilgi.Attach(ogrenci);
                entities.Entry(ogrenci).State = EntityState.Modified;
                entities.SaveChanges();
            }

        }

    }
}
