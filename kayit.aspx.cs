
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class kayit : System.Web.UI.Page
{



    protected void Page_Load(object sender, EventArgs e)
    {
        //merhaba nasıl gidiyor?
        //iyidir ferhat abi senden nasıl gidiyor?
        //aynı devam. caykura beklerim sizi yine ))
        //neyse bakalım probleme
        //sorun neydi? 
        // kutular boşken kayıt yapıyor 
        // kutular boşken kayıt yapmaması lazım  , baglantı koptu bakalım simdi
        //bosken kaytı yapmaması için herhangi bir engel koydunuz mu?
        // if engeli koyduk ama çalışmadıçi
        //& tek başına ve anlamı taşımaz, çift de denedik
        //&& soyad.Text.ToString() != null & email.Text.ToString() != null & sifre.Text.ToString() != null
        //gorduğunuz gibi girmedi bloğa, çünkü string.IsNullOrEmpty komutu hem boş olmamasını hem de nulll olmamasını sağlar
        //ama sizin koyduğunuz kontrol sadece null olmasın diyordu. tmm mıdırı buraya kadar?
        //tamamdır bir sorumuz daha olabilir mi ? tabi
        // login sayfasında sayfa yönlendirmesinde hata alıyoruz
        //kapıya bakıp geleyim ))
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string baglanti = "Data Source= HALENUR; Initial Catalog=db; integrated Security=true;";
        SqlConnection cn = new SqlConnection(baglanti);

        if (!string.IsNullOrEmpty(ad.Text) && !string.IsNullOrEmpty(soyad.Text) && !string.IsNullOrEmpty(email.Text) && !string.IsNullOrEmpty(sifre.Text))
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select email from signup", cn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            if (email.Text != dt2.Rows[0][0].ToString())
            {


                SqlDataAdapter da = new SqlDataAdapter("INSERT INTO signup( firstname, lastname, email, password) values('" + ad.Text + "' ,'" + soyad.Text + "' , '" + email.Text + "' , '" + sifre.Text + "')", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Response.Redirect("Login.aspx");
            }
            else
                Label6.Text = "bu kullanıcı zaten kayıtlı";
        }
        else
        {
            Label5.Text = "Lütfen bilgileri eksiksiz giriniz.";
        }
    }
}