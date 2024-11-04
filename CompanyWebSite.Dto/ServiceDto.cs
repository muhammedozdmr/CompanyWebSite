using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto
{
    public class ServiceDto
    {
        public int Id { get; set; }
        public string? DefaultTitleService { get; set; }
        public string? DefaultContentService { get; set; }
        public string? Summary { get; set; }
        public IEnumerable<HighlightDto> ServiceHighlights { get; set; }
        public IEnumerable<ServiceCategoryDto> ServiceCategories { get; set; }
        public IEnumerable<MediaDto> ServiceMediaItems { get; set; }


    }
}
