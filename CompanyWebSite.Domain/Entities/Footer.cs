using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Domain.Entities
{
    public class Footer
    {
        public int Id { get; set; }
        public string? CompanyInfoTitle { get; set; }
        public string? NewsletterTitle { get; set; } 
        public string? NewsletterPlaceholder { get; set; }
        public string? QuickLinksTitle { get; set; }
    }
}
