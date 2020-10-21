using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVEntity.Models
{
    public class AboutDTO:BaseDTO
    {
        public string Bilgiler { get; set; }
        public string Egitim { get; set; }
        public string IsDeneyim { get; set; }
    }
}
