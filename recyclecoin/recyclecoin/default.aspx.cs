using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Sql;
using System.Collections;

namespace recyclecoin
{
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=RecycleCoinProject;Integrated Security=True");
        public const decimal RC = 100000000;
        public static string kul;
        public void Page_Load(object sender, EventArgs e)
        {



            Label5.Text= Session["Adsoyad"].ToString();
            getBalance();





        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select Carbonvalue from Product where ProductName like'" + ddltip.Text + "'", con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TextBox1.Text = dr["Carbonvalue"].ToString();

            }
            con.Close();

            con.Open();
            SqlCommand kmt = new SqlCommand("select Category from Product where ProductName like'" + ddltip.Text + "'", con);
            SqlDataReader drr = kmt.ExecuteReader();
            while (drr.Read())
            {
                lblkategori.Text = drr["Category"].ToString();

            }
            con.Close();
        }


        private void getBalance()
        {

            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select Bakiye from Usertb where Adsoyad='" + Label5.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //bakiyelbl.Text = dt.Rows[0][0].ToString();
            if (dt.Rows[0][0].ToString() == "0")
            {
                Label3.Text = "0";
            }
            else
            {
                decimal mevcutBakiye = Convert.ToDecimal(dt.Rows[0][0].ToString());
                Label3.Text = mevcutBakiye.ToString();
            }

            con.Close();


        }


        protected void btnFiltrele_Click(object sender, EventArgs e)
        {


        }
        protected void ddltip_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void ddltip_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=RecycleCoinProject;Integrated Security=True");
            Console.WriteLine(con.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select ProductName from Product ", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ddltip.DataTextField = "ProductName";
            ddltip.DataValueField = "ProductName";
            ddltip.DataSource = dt;

            ddltip.DataBind();

            con.Close();






        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select Carbonvalue from Product where ProductName like'" + ddltip.Text + "'", con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TextBox1.Text = dr["Carbonvalue"].ToString();

            }
            con.Close();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddltip_SelectedIndexChanged2(object sender, EventArgs e)
        {



        }
        decimal a;
        decimal b;
        decimal c;

        protected void Button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToDecimal(TextBox1.Text);
            b = Convert.ToDecimal(TextBox2.Text);
            c = (a * b) / RC;

            TextBox3.Text = c.ToString();

            con.Open();
            decimal mevcutBakiye = Convert.ToDecimal(Label3.Text.ToString());
            decimal eklenenBakiye = Convert.ToDecimal(TextBox3.Text.ToString());
            decimal yeniBakiye = mevcutBakiye + eklenenBakiye;

            object yBakiye = yeniBakiye.ToString().Replace(',', '.');

            SqlCommand komut = new SqlCommand("update Usertb set Bakiye='" + yBakiye + "' where Adsoyad='" + Label5.Text.ToString() + "'", con);

            komut.ExecuteNonQuery();

            con.Close();

           Label3.Text = yBakiye.ToString();




        }


    }
}
