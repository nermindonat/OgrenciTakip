using Proje.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.Web.UserKontrol
{
    public partial class OgrenciBilgi : System.Web.UI.UserControl
    {
        Business.OgrBilgi _ogrBilgi = new Business.OgrBilgi();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }


        protected void btnKaydet_ServerClick(object sender, EventArgs e)
        {
            _ogrBilgi.Ekle(new OgrBilgi()
            {
                

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