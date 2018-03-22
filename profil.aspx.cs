using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class profil : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

        string baglanti = "Data Source= HALENUR; Initial Catalog=db; integrated Security=true;";
        SqlConnection cn = new SqlConnection(baglanti);

        if (!Page.IsPostBack)
        {

            SqlDataAdapter da1 = new SqlDataAdapter("select firstname, lastname, email  from signup inner join resim on signup_id=yorum_id  where resim.kullanici_id=@k   ", cn);
            da1.SelectCommand.Parameters.AddWithValue("@k", Giris.MyClass.Id);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            prf.DataSource = dt1;
            prf.DataBind();


            SqlDataAdapter da2 = new SqlDataAdapter("select  yorum from resim  where kullanici_id=@k order by  yorum_id desc ", cn);
            da2.SelectCommand.Parameters.AddWithValue("@k", Giris.MyClass.Id);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            resim.DataSource = dt2;
            resim.DataBind();


            SqlDataAdapter da3 = new SqlDataAdapter("select  yorum from muzik  where kullanici_id=@k order by  yorum_id desc ", cn);
            da3.SelectCommand.Parameters.AddWithValue("@k", Giris.MyClass.Id);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            mu.DataSource = dt3;
            mu.DataBind();


            SqlDataAdapter da4 = new SqlDataAdapter("select  yorum from moda  where kullanici_id=@k order by  yorum_id desc ", cn);
            da4.SelectCommand.Parameters.AddWithValue("@k", Giris.MyClass.Id);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            mo.DataSource = dt4;
            mo.DataBind();

            SqlDataAdapter da5 = new SqlDataAdapter("select  yorum from magazin  where kullanici_id=@k order by  yorum_id desc ", cn);
            da5.SelectCommand.Parameters.AddWithValue("@k", Giris.MyClass.Id);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            ma.DataSource = dt5;
            ma.DataBind();

            SqlDataAdapter da6 = new SqlDataAdapter("select  yorum from spor  where kullanici_id=@k order by  yorum_id desc ", cn);
            da6.SelectCommand.Parameters.AddWithValue("@k", Giris.MyClass.Id);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            sp.DataSource = dt6;
            sp.DataBind();


            SqlDataAdapter da7 = new SqlDataAdapter("select  yorum from siyaset where kullanici_id=@k order by  yorum_id desc ", cn);
            da7.SelectCommand.Parameters.AddWithValue("@k", Giris.MyClass.Id);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            sy.DataSource = dt7;
            sy.DataBind();


            SqlDataAdapter da8 = new SqlDataAdapter("select  yorum from teknoloji where kullanici_id=@k order by  yorum_id desc ", cn);
            da8.SelectCommand.Parameters.AddWithValue("@k", Giris.MyClass.Id);
            DataTable dt8 = new DataTable();
            da8.Fill(dt8);
            tek.DataSource = dt8;
            tek.DataBind();
        }
    }
}