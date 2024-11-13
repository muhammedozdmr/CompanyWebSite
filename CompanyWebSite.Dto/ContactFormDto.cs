using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto
{
    public class ContactFormDto
    {
        public int Id { get; set; }
        public string? FullName { get; set; } // İletişimi kuran kişinin adı
        public string? Email { get; set; } // E-posta adresi
        public string? Phone { get; set; } // Telefon numarası
        public string? Subject { get; set; } // Mesaj konusu
        public string? Message { get; set; } // Mesajın içeriği
        public DateTime? SentDate { get; set; } // Mesajın gönderildiği tarih
        
        // Default Turkish Placeholders
        public string DefaultFullNamePlaceholder { get; set; } = "Adınız Soyadınız";
        public string DefaultEmailPlaceholder { get; set; } = "E-posta Adresiniz";
        public string DefaultPhonePlaceholder { get; set; } = "Telefon Numaranız";
        public string DefaultSubjectPlaceholder { get; set; } = "Konu";
        public string DefaultMessagePlaceholder { get; set; } = "Mesajınız";
        public string DefaultSendButtonText { get; set; } = "Mesaj Gönder";
    }
}
