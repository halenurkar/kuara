using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class master : System.Web.UI.Page
{

    SqlConnection connection = new SqlConnection("Data Source=HALENUR; Initial Catalog=db; integrated Security=sspi;");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            SqlDataAdapter da1 = new SqlDataAdapter("select firstname, lastname, yorum from resim y INNER JOIN signup on y.kullanici_id =signup_id  order by  y.yorum_id desc  ", connection);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            resim.DataSource = dt1;
            resim.DataBind();


            SqlDataAdapter da2 = new SqlDataAdapter("select firstname, lastname, yorum from muzik y INNER JOIN signup on y.kullanici_id =signup_id  order by  y.yorum_id desc  ", connection);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            mu.DataSource = dt2;
            mu.DataBind();

            SqlDataAdapter da3 = new SqlDataAdapter("select firstname, lastname, yorum from magazin y INNER JOIN signup on y.kullanici_id =signup_id  order by  y.yorum_id desc  ", connection);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            ma.DataSource = dt3;
            ma.DataBind();

            SqlDataAdapter da4 = new SqlDataAdapter("select firstname, lastname, yorum from moda y INNER JOIN signup on y.kullanici_id =signup_id  order by  y.yorum_id desc  ", connection);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            mo.DataSource = dt4;
            mo.DataBind();

            SqlDataAdapter da5 = new SqlDataAdapter("select firstname, lastname, yorum from spor y INNER JOIN signup on y.kullanici_id =signup_id  order by  y.yorum_id desc  ", connection);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            sp.DataSource = dt5;
            sp.DataBind();

            SqlDataAdapter da6 = new SqlDataAdapter("select firstname, lastname, yorum from siyaset y INNER JOIN signup on y.kullanici_id =signup_id  order by  y.yorum_id desc  ", connection);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            sy.DataSource = dt6;
            sy.DataBind();



            SqlDataAdapter da7 = new SqlDataAdapter("select firstname, lastname, yorum from teknoloji y INNER JOIN signup on y.kullanici_id =signup_id  order by  y.yorum_id desc  ", connection);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            tek.DataSource = dt7;
            tek.DataBind();

        }
    }
}