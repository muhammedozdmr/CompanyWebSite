using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Domain.Entities
{
    public class Media
    {
        public int Id { get; set; }
        public string? FilePath { get; set; }
        public string? MediaType { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
