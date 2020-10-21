using CVEntity.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntity.WebUI
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        private readonly SkilService _skilService;
        public YetenekGuncelle()
        {
            _skilService = new SkilService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //int id = int.Parse(Request.QueryString["ID"]);
           
            var x = Convert.ToInt32(Request.QueryString["ID"]);
            if (Page.IsPostBack==false)
            {
                var deger = _skilService.GetSingle(x);
                TextBox1.Text = deger.Yetenekler;
            }
             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            var x = Convert.ToInt32(Request.QueryString["ID"]);
            var deger = _skilService.GetSingle(x);
            deger.Yetenekler = TextBox1.Text;

            _skilService.Update(deger, out msg);
            Response.Redirect("Yeteneklerim.aspx");

        }
    }
}