using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto
{
    public class FAQDto
    {
        public int Id { get; set; }
        public string? DefaultTitle { get; set; }
        public string? DefaultContent { get; set; }
        public bool IsActive { get; set; }
        public string? Slug { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
    }
}
