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
    public partial class Default : System.Web.UI.Page
    {
        private readonly AboutService _aboutService;
        private readonly SkilService _skilService;
        private readonly ContactService _contactService;

        public Default()
        {
            _aboutService = new AboutService();
            _skilService = new SkilService();
            _contactService = new ContactService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = _aboutService.GetList();
            Repeater1.DataBind();
            Repeater2.DataSource = _aboutService.GetList();
            Repeater2.DataBind();
            Repeater3.DataSource = _aboutService.GetList();
            Repeater3.DataBind();
            Repeater4.DataSource = _skilService.GetList();
            Repeater4.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            var model = new ContactDTO();
            model.AdSoyad = TextBox1.Text;
            model.Mail = TextBox2.Text;
            model.Konu = TextBox3.Text;
            model.Mesaj = TextBox4.Text;
            _contactService.Save(model,out msg);
            
        }
    }
}