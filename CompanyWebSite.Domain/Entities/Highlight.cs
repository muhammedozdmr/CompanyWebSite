using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Domain.Entities
{
    public class Highlight
    {
        public int Id { get; set; }
        public int? ServiceId { get; set; } // İlgili servise bağlanacak
        public string? Content { get; set; } // Öne çıkan başlık (örn. "Uzmanlık", "Yüksek Performans")
        public Service? Service { get; set; } // Navigation property
    }

}
