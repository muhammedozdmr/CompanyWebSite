using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto
{
    public class BlogSummaryDto
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        public string? Title { get; set; }
        public IEnumerable<BlogCategoryDto> BlogCategories { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
