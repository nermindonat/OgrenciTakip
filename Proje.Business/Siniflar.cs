using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Siniflar
    {
        //public List<Proje.DataAccess.Siniflar> SiniflariIdIleListele(int sinifId)
        //{
        //    Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();
        //    Proje.DataAccess.Siniflar sinif = new Proje.DataAccess.Siniflar();

        //    var siniflar = entities.Siniflar.ToList();
        //    return siniflar;             
        //}

        public List<Proje.DataAccess.Siniflar> SiniflariListele()
        {
            Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();
            Proje.DataAccess.Siniflar sinif = new Proje.DataAccess.Siniflar();

            var siniflar = entities.Siniflar.ToList();
            return siniflar;
        }
        public void Ekle(Siniflar siniflar)
        {
            Proje.DataAccess.OgrenciTakipEntities entities = new Proje.DataAccess.OgrenciTakipEntities();
            Proje.DataAccess.Siniflar sinif = new Proje.DataAccess.Siniflar();
            
            entities.Siniflar.Add(sinif);
            entities.SaveChanges();
        }
    }
}
