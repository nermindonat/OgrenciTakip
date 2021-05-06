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
        protected void Page_Load(object sender, EventArgs e)
        {
            var kisiId = Convert.ToInt32(Session["KulId"]);
            if(string.IsNullOrEmpty((string)Session["AdSoyad"]))
            {
               
                Response.Redirect("Default.aspx");
            }
        }
    }
}