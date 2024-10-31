using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Domain.Entities
{
    public class Blog : BaseEntity
    {
        public string? ImgageUrl { get; set; }
        public string? AuthorImageUrl { get; set; }
        public string? Author { get; set; }
        public string? AuthorTitle { get; set; }
        public DateTime PublishDate { get; set; }
        public ICollection<Category>? Categories { get; set; }
    }
}
