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
        public string? AboutSlogan { get; set; }
        public string? AboutSummary { get; set; }
        public string? ButtonName { get; set; }
        public int CustomerCount { get; set; } = 15;
        public int CustomerSatisfaction { get; set; } = 100;
        public string? OurStepsSlogan { get; set; }
        public string? OurStepsSummary { get; set; }
        public string? ServiceTitle { get; set; }
        public string? ServiceSummary { get; set; }
        public string? FaqSlogan { get; set; }
        public string? FaqQuestion { get; set; }
        public string? FaqAnswer { get; set; }
    }
}
