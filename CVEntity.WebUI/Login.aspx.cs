using CVEntity.Dal.Entityframework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CVEntity.WebUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        CVOzgecmisDBEntities db = new CVOzgecmisDBEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.Admin where x.KullaniciAd == TextBox1.Text && x.Sifre == TextBox2.Text select x;
            if (sorgu.Any())
            {
                Response.Redirect("Istatistik.aspx");
            }
            else
            {
                Response.Write("Kullanıcı adı ya da şifre yanlış");
            }
        }
    }
}