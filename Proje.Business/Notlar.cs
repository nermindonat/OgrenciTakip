using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Notlar
    {
        public int FkOgrBilgiId { get; set; }
        public Nullable<int> Sinav1 { get; set; }
        public Nullable<int> Sinav2 { get; set; }
        public Nullable<int> Performans { get; set; }
        public Nullable<int> Proje { get; set; }

        public List<Proje.DataAccess.Notlar> NotBilgi(int notId)
        {
            Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();
            Proje.DataAccess.Notlar not = new Proje.DataAccess.Notlar();

            var liste = entities.Notlar.Where(p => p.NotId == notId).ToList();
            return liste;
        }

        public List<Proje.DataAccess.Notlar> OgrenciAra(int ogrNo)
        {
            Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();
            Proje.DataAccess.Notlar notlar = new Proje.DataAccess.Notlar();

            var not = entities.Notlar.Where(p => p.FkOgrBilgiId == ogrNo).ToList();
            return not;
        }

        public void Ekle(DataAccess.Notlar notlar)
        {
            Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();

            var not = entities.Notlar.Where(p => p.NotId == notlar.NotId).ToList();

            if (not.Count==0)
            {
                entities.Notlar.Add(notlar);
                entities.SaveChanges();
            }
        }
    }
}
