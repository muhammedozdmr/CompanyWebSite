using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto.LayoutDtos
{
    public class HeaderComponentDto
    {
        public int Id { get; set; }
        public IEnumerable<CompanyInfoDto>? CompanyInfos { get; set; }
        public IEnumerable<SidePanelDto>? SidePanels { get; set; }
        public IEnumerable<NavbarItemDto>? NavbarItems { get; set; }
    }
}
