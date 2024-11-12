using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto
{
    public class HistoryDto
    {
        public int Id { get; set; }
        public string? DefaultTitle { get; set; }
        public string? DefaultContent { get; set; }
        public bool IsActive { get; set; }
        public string? Slug { get; set; }
        public int? Year { get; set; }
        public string? YearDescription { get; set; }
        public string? ProjectUrl { get; set; }
    }
}
