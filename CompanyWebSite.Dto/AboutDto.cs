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
        public string? AboutSlogan { get; set; }
        public string? DefaultTitle { get; set; }
        public string? DefaultContent { get; set; }
        public bool IsActive { get; set; }
        public string? Slug { get; set; }
        public string? ButtonName { get; set; } 
        public string? Summary { get; set; }
        public int CustomerCount { get; set; } = 15;
        public int CustomerSatisfaction { get; set; } = 100;
        public int? CompanyInfoId { get; set; }
        public IEnumerable<HistoryDto>? Histories { get; set; }
        public IEnumerable<PageDto>? Pages { get; set; }
    }
}
