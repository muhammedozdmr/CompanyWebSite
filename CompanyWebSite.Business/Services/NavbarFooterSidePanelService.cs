using CompanyWebSite.Business.Repository.Interface;
using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto;

namespace CompanyWebSite.Business.Services;

public class NavbarFooterSidePanelService : INavbarFooterSidePanelService
{
    private readonly INavbarItemService _navbarItemService;
    private readonly INewsletterService _newsletterService;
    private readonly ICompanyInfoService _companyService;
    private readonly IFooterService _footerService;
    private readonly ISidePanelService _sidePanelService;
    private readonly ILanguageRepository _languageRepository;

    public NavbarFooterSidePanelService(INavbarItemService navbarItemService, INewsletterService newsletterService, ICompanyInfoService companyService, IFooterService footerService, ISidePanelService sidePanelService, ILanguageRepository languageRepository)
    {
        _navbarItemService = navbarItemService;
        _newsletterService = newsletterService;
        _companyService = companyService;
        _footerService = footerService;
        _sidePanelService = sidePanelService;
        _languageRepository = languageRepository;
    }

    public async Task<IEnumerable<NavbarFooterSidePanelDto>> GetNavbarFooterSidePanelAllAsync(string languageCode)
    {
        var navbarItems = await _navbarItemService.GetNavbarItemAllAsync(languageCode);
        var newsletter = await _newsletterService.GetNewsletterAllAsync(languageCode);
        var companyInfo = await _companyService.GetCompanyInfoAllAsync(languageCode);
        var footer = await _footerService.GetFooterAllAsync(languageCode);
        var sidePanel = await _sidePanelService.GetSidePanelAllAsync(languageCode);
        var languages = await _languageRepository.GetAllAsync();
        return new List<NavbarFooterSidePanelDto>
        {
            new NavbarFooterSidePanelDto
            {
                NavbarItems = navbarItems,
                Newsletters = newsletter,
                CompanyInfos = companyInfo,
                Footers = footer,
                SidePanels = sidePanel,
                Languages = languages.Select(x=> new LanguageDto
                {
                    Id = x.Id,
                    Code = x.Code,
                    Name = x.Name
                })
            }
        };
    }
}
