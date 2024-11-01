using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Domain.Entities
{
    public class BlogCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<Blog>? Blogs { get; set; } // Blog ile ilişki
    }

}
