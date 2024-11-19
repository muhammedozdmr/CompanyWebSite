using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto.LayoutDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services
{
    public class HeaderComponentService : IHeaderComponentService
    {
        private readonly ICompanyInfoService _companyInfoService;
        private readonly ISidePanelService _sidePanelService;
        private readonly INavbarItemService _navbarItemService;

        public HeaderComponentService(ICompanyInfoService companyInfoService, ISidePanelService sidePanelService, INavbarItemService navbarItemService)
        {
            _companyInfoService = companyInfoService;
            _sidePanelService = sidePanelService;
            _navbarItemService = navbarItemService;
        }
        public async Task<IEnumerable<HeaderComponentDto>> GetHeaderComponentAllAsync(string languageCode)
        {
            var navbar = await _navbarItemService.GetNavbarItemAllAsync(languageCode);
            var companyInfo = await _companyInfoService.GetCompanyInfoAllAsync(languageCode);
            var sidePanel = await _sidePanelService.GetSidePanelAllAsync(languageCode);

            var headerItems = new List<HeaderComponentDto>
            {
                new HeaderComponentDto
                {
                    CompanyInfos = companyInfo,
                    SidePanels = sidePanel,
                    NavbarItems = navbar
                }
            };
            return headerItems;
        }
    }
}
