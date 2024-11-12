using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Domain.Entities
{
    public class History : BaseEntity
    {
        public int? Year { get; set; }
        public string? YearDescription { get; set; }
        public string? ProjectUrl { get; set; }
        public int? AboutId { get; set; }
        public About About { get; set; }
    }
}
