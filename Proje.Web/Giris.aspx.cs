using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.Web
{
    public partial class Giris1 : System.Web.UI.Page
    {
        Business.Kullanicilar _kullanicilar = new Business.Kullanicilar();
        Business.KullaniciTurleri _kullaniciTurleri = new Business.KullaniciTurleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            //KullanicilariListele();
        }

        //private void KullanicilariListele()
        //{
        //    throw new NotImplementedException();
        //}

        protected void btnGiris_OnServerClick(object sender, EventArgs e)
        {
            int kullaniciTurId = int.Parse(Request.QueryString["kullaniciTurId"]);
            string kullaniciEmail = tbxKullaniciEmail.Value;
            string kullaniciSifre = tbxSifre.Value;

            var kullanici = _kullanicilar.KullaniciKontrol(kullaniciEmail, kullaniciSifre, kullaniciTurId);

            foreach (var kul in kullanici)
            {
                if((kul.Email==kullaniciEmail) && (kul.Sifre == kullaniciSifre))
                {
                   
                    if (kullanici.Count >= 1)
                    {
                        foreach (var oturum in kullanici)
                        {
                            Session["KulId"] = oturum.KulId;
                            Session["KulTurId"] = oturum.FkKulTurId;
                            Session["AdSoyad"] = oturum.KulAd + " " + oturum.KulSoyad;
                        }

                        Session["KullaniciTurAd"] = _kullaniciTurleri.KullaniciTurAdGetir(kullaniciTurId);
                        
                        Response.Redirect("Default.aspx");

                    }

                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Hatalı giriş";

                    }
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Hatalı giriş";

                }
            }                       
        }
    }
}