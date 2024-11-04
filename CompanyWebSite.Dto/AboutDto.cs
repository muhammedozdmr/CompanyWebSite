using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto
{
    public class AboutDto
    {
        public int Id { get; set; }
        public string? DefaultTitleAbout { get; set; }
        public string? DefaultContentAbout { get; set; }
        public bool IsActive { get; set; }
        public string? Slug { get; set; }
        public string? ButtonName { get; set; }
        public string? Summary { get; set; }
        public int CustomerCount { get; set; } = 15;
        public int CustomerSatisfaction { get; set; } = 100;
        public string? DefaultTitleHistory { get; set; }
        public string? DefaultContentHistory { get; set; }
        public int? Year { get; set; }
        public string? YearDescription { get; set; }
    }
}
