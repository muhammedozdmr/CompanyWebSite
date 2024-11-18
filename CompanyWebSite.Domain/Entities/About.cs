using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Domain.Entities
{
    public class About : BaseEntity
    {
        public string? Summary { get; set; }
        public string? AboutSlogan { get; set; }
        public int CompanyInfoId { get; set; }
        public CompanyInfo? CompanyInfo { get; set; }
        public IEnumerable<History> Histories { get; set; }
    }
}
