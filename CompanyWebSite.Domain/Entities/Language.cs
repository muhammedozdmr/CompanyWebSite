using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Domain.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string? Name { get; set; } // Dil adı (örneğin: "Türkçe", "English")
        public string? Code { get; set; } // Dil kodu (örneğin: "tr", "en")

        // Navigation properties
        public ICollection<Translation>? Translations { get; set; } // Bu dile ait çeviriler
    }
}
