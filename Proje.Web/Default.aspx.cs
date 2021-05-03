using Proje.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.Web
{
    public partial class Default : System.Web.UI.Page
    {
        Business.Menuler menuler = new Business.Menuler();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MenuleriListele();
            }
            

        }

        private void MenuleriListele()
        {
            var liste = menuler.MenuleriListele();
            rptMenuler.DataSource = liste;
            rptMenuler.DataBind();
        }      
    }
}