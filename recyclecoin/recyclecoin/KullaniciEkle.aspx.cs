using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace recyclecoin
{
    public partial class KullaniciGiris : System.Web.UI.Page
    {
        internal static string kul;
        internal static readonly string dul;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=RecycleCoinProject;Integrated Security=True");
            con.Open();
            if (string.IsNullOrEmpty(txtAdsoyad.Text) || string.IsNullOrEmpty(txtEposta.Text) || string.IsNullOrEmpty(txtKadi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                Response.Write("LÜTFEN BOŞ ALANLARI DOLDURUNUZ !!!");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Insert into Usertb(Kadi, Adsoyad, Eposta, Sifre ) values('" + txtKadi.Text + "','" + txtAdsoyad.Text + "','" + txtEposta.Text + "','" + txtSifre.Text + "')", con);
                cmd.ExecuteNonQuery();
                Response.Write("BAŞARIYLA SİSTEME KAYIT OLUNDU !!!");
                Response.Redirect("KullaniciGiris.aspx");

            }
            con.Close();









        }
    }
}