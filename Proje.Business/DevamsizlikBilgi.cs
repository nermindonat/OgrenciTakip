using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class DevamsizlikBilgi
    {
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

        }

    }
}
