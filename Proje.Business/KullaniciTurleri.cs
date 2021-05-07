using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{

    public class KullaniciTurleri
    {
        public string KulTurAd { get; set; }
        public string KullaniciTurAdGetir(int kulTurId)
        {
            Proje.DataAccess.OgrenciTakipEntities1 entities = new Proje.DataAccess.OgrenciTakipEntities1();
            Proje.DataAccess.KullaniciTurleri kullaniciTurleri = new Proje.DataAccess.KullaniciTurleri();

            string kullaniciTurAd = null;
            var liste  = entities.KullaniciTurleri.Where(p => p.KulTurId == kulTurId).ToList();
            foreach(var kullanici in liste)
            {
                kullaniciTurAd = kullanici.KulTurAd;          
            }
            return kullaniciTurAd;
        }
    }
}
