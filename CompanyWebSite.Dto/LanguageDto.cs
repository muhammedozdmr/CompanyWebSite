using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto
{
    public class LanguageDto
    {
        public int Id { get; set; }
        public string? Name { get; set; } // Dil adı (örn: "Türkçe", "English")
        public string Code { get; set; } // Dil kodu (örn: "tr", "en")
    }
}
