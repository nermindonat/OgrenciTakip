using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.Web.UserKontrol
{
    public partial class UserNotGirisi : System.Web.UI.UserControl
    {
        Business.Notlar _not = new Business.Notlar();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAra_ServerClick(object sender, EventArgs e)
        {
            int ogrNo = int.Parse(txtOgrenciNoAra.Value);
            var ogrenci = _not.OgrenciAra(ogrNo);

            if (ogrenci.Count != 0)
            {
                foreach (var i in ogrenci)
                {
                    txtOgrenciId.Value = i.NotId.ToString();
                    txtOgrenciNo.Value = i.FkOgrBilgiId.ToString();
                    txtSinav1.Value = i.Sinav1.ToString();
                    txtSinav2.Value = i.Sinav2.ToString();
                    txtPerformans.Value = i.Performans.ToString();
                    txtProje.Value = i.Proje.ToString();
                }

            }
        }

        protected void btnKaydet_ServerClick(object sender, EventArgs e)
        {
            _not.Ekle(new DataAccess.Notlar()
            {
                NotId = int.Parse(txtNotId.Value),
                FkOgrBilgiId=int.Parse(txtOgrenciId.Value),
                Sinav1=int.Parse(txtSinav1.Value),
                Sinav2=int.Parse(txtSinav2.Value),
                Performans=int.Parse(txtPerformans.Value),
                Proje=int.Parse(txtProje.Value),

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