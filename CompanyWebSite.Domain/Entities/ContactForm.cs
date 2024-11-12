using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Domain.Entities
{
    public class ContactForm
    {
        public int Id { get; set; }
        public string? FullName { get; set; } // İletişimi kuran kişinin adı
        public string? Email { get; set; } // E-posta adresi
        public string? Phone { get; set; } // Telefon numarası
        public string? Subject { get; set; } // Mesaj konusu
        public string? Message { get; set; } // Mesajın içeriği
        public DateTime? SentDate { get; set; } // Mesajın gönderildiği tarih
        
        // Default Turkish Placeholders
        public string DefaultFullNamePlaceholder = "Adınız Soyadınız";
        public string DefaultEmailPlaceholder = "E-posta Adresiniz";
        public string DefaultPhonePlaceholder = "Telefon Numaranız";
        public string DefaultSubjectPlaceholder = "Konu";
        public string DefaultMessagePlaceholder = "Mesajınız";
        public string DefaultSendButtonText = "Mesaj Gönder";
    }
}
