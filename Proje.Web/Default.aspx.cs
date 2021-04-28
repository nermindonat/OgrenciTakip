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
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-NJ1RRJV/MSSQLSERVER01;Initial Catalog=OgrenciTakip;Integrated Security=True");
            SqlCommand komut = new SqlCommand("SELECT * FROM Menuler", baglanti);
            baglanti.Open();
            SqlDataReader reader = komut.ExecuteReader();


            rptMenuler.DataSource = rptMenuler;
            rptMenuler.DataBind();
            //Listele();
        }

        private void Listele()
        {
            
        }
    }
}