using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Domain.Entities
{
    public class Translation
    {
        public int Id { get; set; }
        public string? EntityName { get; set; } // Hangi entity'ye ait olduğu ("Project", "Blog", "Resume" vs.)
        public int? EntityId { get; set; } // İlgili entity'nin ID'si
        public string? Key { get; set; } // Çevirilecek alanın adı ("Title", "Description" gibi)
        public string? Value { get; set; } // Çevrilmiş değer

        // Foreign key
        public int? LanguageId { get; set; }
        public Language Language { get; set; } // Navigation property
    }
}
