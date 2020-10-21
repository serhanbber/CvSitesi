using CVEntity.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntity.WebUI
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        private readonly ContactService _contactService;
        public MesajDetay()
        {
            _contactService = new ContactService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var x = Convert.ToInt32(Request.QueryString["ID"]);
            var mesaj = _contactService.GetSingle(x);
            txtAdSoyad.Text = mesaj.AdSoyad;
            txtMail.Text = mesaj.Mail;
            txtKonu.Text = mesaj.Konu;
            txtMesaj.Text = mesaj.Mesaj;
        }
    }
}