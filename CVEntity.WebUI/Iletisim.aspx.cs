using CVEntity.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntity.WebUI
{
    public partial class Iletisim : System.Web.UI.Page
    {
        private readonly ContactService _contactService;
        public Iletisim()
        {
            _contactService = new ContactService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = _contactService.GetList();
            Repeater1.DataBind();
        }
    }
}