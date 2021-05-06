using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Kullanicilar
    {
        public string Email { get; set; }
        public string Sifre { get; set; }




        public List<Proje.DataAccess.Kullanicilar> KullaniciKontrol(string email, string sifre, int kullaniciTurId)
        {
            Proje.DataAccess.OgrenciTakipEntities1 entities = new Proje.DataAccess.OgrenciTakipEntities1();
            Proje.DataAccess.Kullanicilar kullanicilar = new Proje.DataAccess.Kullanicilar();

            var liste = entities.Kullanicilar.Where(p => p.FkKulTurId == kullaniciTurId && p.Email == email && p.Sifre == sifre).ToList();
            return liste;

        }


    }
}
