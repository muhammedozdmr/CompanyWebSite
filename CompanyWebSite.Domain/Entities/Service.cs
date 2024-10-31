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
        public ICollection<Category>? Categories { get; set; }
        public ICollection<Media>? MediaItems { get; set; }
    }
}
