using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto
{
    public class ContactDto
    {
        public int Id { get; set; }
        public string? WorkingHours { get; set; } // Çalışma saatleri
        public IEnumerable<CompanyInfoDto> CompanyInfo { get; set; }
        public IEnumerable<ContactFormDto> ContactForm { get; set; }
    }
}
