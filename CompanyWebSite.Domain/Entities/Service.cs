using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Domain.Entities
{
    public class Service : BaseEntity
    {
        public string? ServiceSummary { get; set; }
        public string? ServiceSlogan { get; set; }
        public string? ServiceHomeTitle { get; set; }
        public ICollection<ServiceCategory>? ServiceCategories { get; set; }
        public ICollection<Media>? MediaItems { get; set; }
        public ICollection<Highlight>? Highlights { get; set; }
    }
}
