using CVEntity.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntity.WebUI
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        private readonly SkilService _skilService;
        public YetenekSil()
        {
            _skilService = new SkilService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string msg = "";
            var x = Convert.ToInt32(Request.QueryString["ID"]);
            var yetenek = _skilService.GetSingle(x);

            _skilService.Delete(yetenek.ID,out msg);
            Response.Redirect("Yeteneklerim.aspx");
          
        }
    }
}