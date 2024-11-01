using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Domain.Entities
{
    public class ServiceCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<Service>? Services { get; set; } // Service ile ilişki
    }

}
