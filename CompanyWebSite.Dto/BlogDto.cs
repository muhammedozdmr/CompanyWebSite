using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto
{
    public class BlogDto
    {
        public int Id { get; set; }
        public string DefaultTitle { get; set; }
        public string DefaultContent { get; set; } // Blog yazısının tam metni
        public string Author { get; set; }
        public string AuthorTitle { get; set; }
        public DateTime PublishDate { get; set; }
        public IEnumerable<BlogCategoryDto> Categories { get; set; } // Blog kategorileri
        public string ImageUrl { get; set; } // Blog kapağı görseli
        public string AuthorImageUrl { get; set; } // Yazarın görseli
    }
}
