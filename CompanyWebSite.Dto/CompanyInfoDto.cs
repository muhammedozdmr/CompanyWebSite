using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto
{
    public class CompanyInfoDto
    {
        public int Id { get; set; }
        public string? CompanyLogoUrl { get; set; } // Resim URL'si
        public string? CompanyName { get; set; } // Company Name
        public string? CompanyArea { get; set; } // Şirket Ünvanı
        public string? WorkingHours { get; set; } // Çalışma saatleri
        public DateTime? CreateDate { get; set; } // Kuruluş tarihi
        public string? Residence { get; set; } // İkamet yeri (Şehir/Ülke)
        public string? Address { get; set; } // Adres
        public string? Email { get; set; } // E-posta adresi
        public string? Phone { get; set; } // Telefon numarası
        public string? LinkedIn { get; set; } // LinkedIn URL'si
        public string? Twitter { get; set; } // Twitter URL'si,
        public string? Facebook { get; set; } // Facebook URL'si
        public string? Instagram { get; set; } // Instagram URL'si
    }
}
