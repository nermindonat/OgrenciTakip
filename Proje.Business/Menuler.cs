using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Menuler 
    {
        public string MenuAd { get; set; }

        public List<Proje.DataAccess.Menuler> MenuleriListele()
        {
            Proje.DataAccess.OgrenciTakipEntities1 entities = new Proje.DataAccess.OgrenciTakipEntities1();
            Proje.DataAccess.Menuler menuler = new Proje.DataAccess.Menuler();

            var liste = entities.Menuler.ToList();
            return liste;


        }
    }
}
