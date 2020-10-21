using CVEntity.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntity.WebUI
{
    public partial class Istatistik : System.Web.UI.Page
    {
        private readonly SkilService _skilService;
        private readonly ContactService _contactService;
        public Istatistik()
        {
            _skilService = new SkilService();
            _contactService = new ContactService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = _skilService.GetList().Count().ToString();
            Label2.Text = _contactService.GetList().Count().ToString();
            Label3.Text = _skilService.GetList().Average(x=>x.Derece).ToString();
            Label4.Text = _skilService.GetList().Max(x=>x.Derece).ToString();
        }
    }
}