using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto.LayoutDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services
{
    public class FooterComponentService : IFooterComponentService
    {
        private readonly IFooterService _footerService;
        private readonly INavbarItemService _navbarItemService;
        private readonly ICompanyInfoService _companyInfoService;
        public FooterComponentService(IFooterService footerService, INavbarItemService navbarItemService, ICompanyInfoService companyInfoService)
        {
            _footerService = footerService;
            _navbarItemService = navbarItemService;
            _companyInfoService = companyInfoService;
        }
        public async Task<IEnumerable<FooterComponentDto>> GetFooterComponentAllAsync(string languageCode)
        {
            var footer = await _footerService.GetFooterAllAsync(languageCode);
            var navbar = await _navbarItemService.GetNavbarItemAllAsync(languageCode);
            var companyInfo = await _companyInfoService.GetCompanyInfoAllAsync(languageCode);

            var footerItems = new List<FooterComponentDto>
            {
                new FooterComponentDto
                {
                    CompanyInfos = companyInfo,
                    NavbarItems = navbar,
                    Footers = footer
                }
            };
            return footerItems;
        }
    }
}
