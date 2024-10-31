using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string? FullName { get; set; } // İletişimi kuran kişinin adı
        public string? Email { get; set; } // E-posta adresi
        public string? Phone { get; set; } // Telefon numarası
        public string? Subject { get; set; } // Mesaj konusu
        public string? Message { get; set; } // Mesajın içeriği
        public DateTime? SentDate { get; set; } // Mesajın gönderildiği tarih
    }
}
