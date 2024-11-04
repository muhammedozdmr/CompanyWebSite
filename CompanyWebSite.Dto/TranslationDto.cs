using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto
{
    public class TranslationDto
    {
        public int Id { get; set; }
        public string? EntityName { get; set; } // Hangi entity'ye ait ("Project", "Blog" vs.)
        public int? EntityId { get; set; } // İlgili entity'nin ID'si
        public string? Key { get; set; } // Çevirilecek alan adı (örn: "Title", "Description")
        public string? Value { get; set; } // Çevirilen değer
        public int? LanguageId { get; set; } // Çeviri dili
    }
}
