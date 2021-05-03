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

            

            if (kullanici.Count>=1)
            {

                Session["Email"] = tbxKullaniciEmail;
                Session["KulAd"] = "kulAd";
                Session["KulId"] = "kullaniciId";
                Session["Sifre"] = tbxSifre;
                Session["KulTurId"] = "kullaniciTurId";

                Response.Redirect("Default.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Hatalı giriş";

            }
        }
    }
}