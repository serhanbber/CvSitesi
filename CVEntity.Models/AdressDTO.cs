using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVEntity.Models
{
    public class AdressDTO:BaseDTO
    {
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string Konum { get; set; }
    }
}
