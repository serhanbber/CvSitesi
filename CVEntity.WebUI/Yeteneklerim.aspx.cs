using CVEntity.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntity.WebUI
{
    public partial class Hakkimda : System.Web.UI.Page
    {
       
        private readonly SkilService _skilService;
        public Hakkimda()
        {
            _skilService = new SkilService();
        }
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = _skilService.GetList();
            Repeater1.DataBind();
        }
    }
}