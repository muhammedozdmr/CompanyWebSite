using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto;

namespace CompanyWebSite.Business.Services;

public class NavbarAndFooterService : INavbarAndFooterService
{
    private readonly INavbarItemService _navbarItemService;
    private readonly INewsletterService _newsletterService;
    private readonly ICompanyInfoService _companyService;

    public NavbarAndFooterService(INavbarItemService navbarItemService, INewsletterService newsletterService, ICompanyInfoService companyService)
    {
        _navbarItemService = navbarItemService;
        _newsletterService = newsletterService;
        _companyService = companyService;
    }

    public async Task<IEnumerable<NavbarAndFooterDto>> GetFooterAllAsync(string languageCode)
    {
        var navbarItems = await _navbarItemService.GetNavbarItemAllAsync(languageCode);
        var newsletter = await _newsletterService.GetNewsletterAllAsync(languageCode);
        var companyInfo = await _companyService.GetCompanyInfoAllAsync(languageCode);
        return new List<NavbarAndFooterDto>
        {
            new NavbarAndFooterDto
            {
                NavbarItems = navbarItems,
                Newsletters = newsletter,
                CompanyInfos = companyInfo
            }
        };
    }
}
