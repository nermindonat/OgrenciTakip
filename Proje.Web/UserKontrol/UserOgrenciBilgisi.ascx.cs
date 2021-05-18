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
            ddlSinif.DataSource = liste;
            ddlSinif.DataTextField = "Sube";
            ddlSinif.DataValueField = "SinifId";
            ddlSinif.DataBind();
        }

        protected void btnKaydet_ServerClick(object sender, EventArgs e)
        {
            _ogrBilgi.Ekle(new DataAccess.OgrBilgi()
            {
                FkSinifId = Convert.ToInt32(ddlSinif.SelectedValue),
                OgrAd = txtOgrenciAd.Value,
                OgrSoyad = txtOgrenciSoyad.Value,
                OgrNo = int.Parse(txtOgrenciNo.Value),
                Adres = txtAdres.Value
            });

        }

        protected void btnGuncelle_ServerClick(object sender, EventArgs e)
        {
            if (!txtOgrenciId.Value.Equals(""))
            {
                _ogrBilgi.Guncelle(new DataAccess.OgrBilgi()
                {
                    OgrBilgiId=int.Parse(txtOgrenciId.Value),
                    FkSinifId=int.Parse(ddlSinif.SelectedValue),
                    OgrAd=txtOgrenciAd.Value,
                    OgrSoyad=txtOgrenciSoyad.Value,
                    OgrNo=int.Parse(txtOgrenciNo.Value),
                    Adres=txtAdres.Value,
                });
            }

        }

        protected void btnSil_ServerClick(object sender, EventArgs e)
        {
            _ogrBilgi.Sil(int.Parse(txtOgrenciId.Value));
        }

        protected void btnAra_ServerClick(object sender, EventArgs e)
        {
            int ogrenciNo = int.Parse(txtOgrenciNoAra.Value);
            var ogrenci = _ogrBilgi.OgrenciAra(ogrenciNo);

            if (ogrenci.Count != 0)
            {
                foreach (var i in ogrenci)
                {
                    txtOgrenciId.Value = i.OgrBilgiId.ToString();
                    txtOgrenciNo.Value = i.OgrNo.ToString();
                    txtOgrenciAd.Value = i.OgrAd;
                    txtOgrenciSoyad.Value = i.OgrSoyad;
                    ddlSinif.SelectedValue = i.FkSinifId.ToString();
                    txtAdres.Value = i.Adres;
                }
            }      

        }
    }
}