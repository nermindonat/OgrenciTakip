using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.Web.UserKontrol
{
    public partial class UserOgrenciBilgisi : System.Web.UI.UserControl
    {
        Business.OgrBilgi _ogrBilgi = new Business.OgrBilgi();
        Business.Siniflar _sinif = new Business.Siniflar();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                SiniflariListele();
            }
        }

        private void SiniflariListele()
        {
            var liste = _sinif.SiniflariListele();
            selectSinif.DataSource = liste;
            selectSinif.DataTextField = "Sube";
            selectSinif.DataValueField = "SinifId";
            selectSinif.DataBind();
        }

        protected void btnKaydet_ServerClick(object sender, EventArgs e)
        {
            _ogrBilgi.Ekle(new Business.OgrBilgi()
            {
                OgrNo=int.Parse(txtOgrenciNo.Value),
                               
                OgrAd=txtOgrenciAd.Value,
                OgrSoyad=txtOgrenciSoyad.Value,
                Adres=txtAdres.Value              
                
            });

        }

        protected void btnGuncelle_ServerClick(object sender, EventArgs e)
        {

        }

        protected void btnSil_ServerClick(object sender, EventArgs e)
        {

        }
    }
}