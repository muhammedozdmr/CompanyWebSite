using CompanyWebSite.Dto;

namespace CompanyWebSite.Business.Services.Interface;

public interface INavbarFooterSidePanelService
{
    public Task<IEnumerable<NavbarFooterSidePanelDto>> GetNavbarFooterSidePanelAllAsync(string languageCode);
}
