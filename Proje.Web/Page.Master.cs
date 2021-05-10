using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.Web
{
    public partial class Page : System.Web.UI.MasterPage
    {
        Business.Menuler _menuler = new Business.Menuler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var kisiId = Convert.ToInt32(Session["KulId"]);
                var kulTurId = Convert.ToInt32(Session["KulTurId"]);
                if (string.IsNullOrEmpty((string)Session["AdSoyad"]))
                {

                    Response.Redirect("Giris.aspx");
                }

                MenuleriListele(kulTurId);
            }           
        }

        private void MenuleriListele(int kulTurId)
        {
            var liste = _menuler.KulllaniciTurIdIleListele(kulTurId);
            rptMenuler.DataSource = liste;
            rptMenuler.DataBind();
        }
    }
}