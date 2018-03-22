using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        
    }
    protected void giris_Click(object sender, EventArgs e)
    {
        SqlConnectionStringBuilder sc = new SqlConnectionStringBuilder();
        sc.DataSource = "HALENUR";
        sc.IntegratedSecurity = true;
        sc.InitialCatalog = "db";


        SqlConnection cn = new SqlConnection(sc.ConnectionString);
        //string sorgu = "select email , password from signup where email='" + email.Text + "' and password='" + sifre.Text + "'";
        //SqlDataAdapter da = new SqlDataAdapter(sorgu, cn);
        //DataTable dt = new DataTable();
        //da.Fill(dt);

        cn.Open();
        SqlCommand command = new SqlCommand();
        command.CommandText = "Select signup_id,email,password From signup Where email = @email AND password = @password";
        command.Parameters.AddWithValue("@email", email.Text);
        command.Parameters.AddWithValue("@password", sifre.Text);
        command.Connection = cn;

        SqlDataReader reader = command.ExecuteReader();
        if(reader.Read())
        {
            Giris.MyClass.Id = Convert.ToInt32(reader[0]);
            Session.Add("signup_id", Convert.ToInt32(reader[0]));
            cn.Dispose();
            cn.Close();
            Response.Redirect("master.aspx");
        }
        else
        {
            lblnot.Text = "Kullanıcı adı veya şifre hatalı";
            cn.Close();
            cn.Dispose();
        }


        //anı
        // kayıt sayfasında oluşturulan kayıtı login tablosunda referans aldık bu sekilde login olamıyoruz
        //biraz uzadı kusura bakmayın.  sorun yukarıda yazılan mı?
        // anasayfaya yönlendirme yapamıyor if koşulundan dolayı
        // umarım try cash ler unutulmamıstır ))
        //baska ?
        // Allah razı olsun :)
        //canımsınız   sorun oldugunda cekinmeden arayın, iyi çalışmalar
        //çok sagol Ferhat abi  )) 


    //    try
    //    {
    //        if (email.Text == dt.Rows[0][0].ToString() && sifre.Text == dt.Rows[0][1].ToString())
    //        {
    //            if (cn.State != ConnectionState.Open)
    //            {
    //                cn.Open();
    //            }


    //            SqlCommand command = new SqlCommand("SELECT signup_id FROM signup WHERE email=@e AND password=@p", cn);
    //            command.Parameters.AddWithValue("@e", email.Text);
    //            command.Parameters.AddWithValue("@p", sifre.Text);

    //            SqlDataReader reader = command.ExecuteReader();


    //            while (reader.Read())
    //            {
    //                Giris.MyClass.Id = reader.GetInt32(0);
    //                //  Giris.MyClass.ad = reader.GetString(3);
                   
    //            }
    //            reader.Close();


    //            SqlDataAdapter da1 = new SqlDataAdapter("select firstname, lastname, email from signup where kullanici_id=@k",cn);
    //            da1.SelectCommand.Parameters.AddWithValue("@k", Giris.MyClass.Id);

             
    //            Response.Redirect("master.aspx");  
    //        }
    //        else
    //        {
    //            lblnot.Text = "Kullanıcı adı veya parola yanlış !!";
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        // lblnot.Text=ex.Message; 
    //        lblnot.Text = "Kullanıcı adı veya parola yanlış !!";
    //    }
    }

    protected void kayit_Click(object sender, EventArgs e)
    {
        Response.Redirect("kayit.aspx");
    }

}