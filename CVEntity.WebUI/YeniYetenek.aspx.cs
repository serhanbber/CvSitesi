using CVEntity.Business.Services;
using CVEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntity.WebUI
{
    public partial class YeniYetenek : System.Web.UI.Page
    {
        private readonly SkilService _skilService;
        public YeniYetenek()
        {
            _skilService = new SkilService();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            var model = new SkilDTO();
            model.Yetenekler = TextBox1.Text;
           
            _skilService.Save(model, out msg);
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}