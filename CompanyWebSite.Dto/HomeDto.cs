using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto
{
    public class HomeDto
    {
        public int Id { get; set; }
        
        public IEnumerable<AboutDto>? About { get; set; }
        public IEnumerable<ServiceDto>? Services { get; set; }
        public IEnumerable<FAQDto>? FQ { get; set; }
        public string? ButtonName { get; set; }
        public int CustomerCount { get; set; } = 15;
        public int CustomerSatisfaction { get; set; } = 100;
        public IEnumerable<SidePanelDto>? SidePanels { get; set; }
        public IEnumerable<CompanyInfoDto>? CompanyInfos { get; set; }
        public IEnumerable<NavbarFooterSidePanelDto>? NavbarFooterSidePanels { get; set; }
        public IEnumerable<NewsletterDto>? Newsletters { get; set; }
    }
}
