using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;


namespace recyclecoin
{
    public partial class KullaniciEkle : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlDataReader dr;
        public static string kul;
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=RecycleCoinProject;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select *from Usertb Where Kadi='" + txtKadi.Text + "' and Sifre ='" + txtSifre.Text + "'", con);
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {

                Session["Adsoyad"] = dr["Adsoyad"].ToString();
                Response.Redirect("default.aspx");
                


            }
            else
            {
                Response.Write("Kullanıcı adı veya Şifre hatalı");

            }
            con.Close();


        }




        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("KullaniciEkle.aspx");

        }
        
        public void txtKadi_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}