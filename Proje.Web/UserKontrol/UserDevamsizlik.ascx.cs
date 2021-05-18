﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Proje.Web.UserKontrol
{
    public partial class UserDevamsizlik : System.Web.UI.UserControl
    {
        Business.OgrBilgi _ogrBilgi = new Business.OgrBilgi();
        Business.Siniflar _siniflar = new Business.Siniflar();
        Business.DevamsizlikBilgi _devamsizlikBilgi = new Business.DevamsizlikBilgi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SiniflariListele();
            }
        }

        private void SiniflariListele()
        {
            var liste = _siniflar.SiniflariListele();
            ddlSinif.DataSource = liste;
            ddlSinif.DataTextField = "Sube";
            ddlSinif.DataValueField = "SinifId";
            ddlSinif.DataBind();
           
        }

        protected void btnOgrenciNoAra_ServerClick(object sender, EventArgs e)
        {
            int ogrNo = int.Parse(txtOgrenciNoAra.Value);
            var ogrenci = _ogrBilgi.OgrenciAra(ogrNo);

            if (ogrenci.Count != 0)
            {
                foreach (var i in ogrenci)
                {
                    txtOgrenciId.Value = i.OgrBilgiId.ToString();
                    txtOgrenciNo.Value = i.OgrNo.ToString();
                    txtOgrenciAd.Value = i.OgrAd;
                    txtOgrenciSoyad.Value = i.OgrSoyad;
                    ddlSinif.SelectedValue = i.FkSinifId.ToString();
                }

            }
        }

        protected void btnKaydet_ServerClick(object sender, EventArgs e)
        {

            _devamsizlikBilgi.Ekle(new DataAccess.DevamsizlikBilgi()
            {
                DevamsizlikTarih = DateTime.Parse(txtTarih.Value),
                DevamsizlikTur = selectDevamsizlikTur.Value,
                FkOgrBilgiId = int.Parse(txtOgrenciId.Value)
            });
  
        }

        protected void btnGuncelle_ServerClick(object sender, EventArgs e)
        {
            if (!txtOgrenciId.Value.Equals(""))
            {
                _devamsizlikBilgi.Guncelle(new DataAccess.DevamsizlikBilgi)
                    {

                }
            }
            

        }

        protected void btnSil_ServerClick(object sender, EventArgs e)
        {

        }
    }
}