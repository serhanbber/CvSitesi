using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVEntity.Models
{
    public class ContactDTO:BaseDTO
    {
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Mesaj { get; set; }
        public string Konu { get; set; }
    }
}
