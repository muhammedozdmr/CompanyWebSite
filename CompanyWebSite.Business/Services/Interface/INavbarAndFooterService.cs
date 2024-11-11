using CompanyWebSite.Dto;

namespace CompanyWebSite.Business.Services.Interface;

public interface INavbarAndFooterService
{
    public Task<IEnumerable<NavbarAndFooterDto>> GetFooterAllAsync(string languageCode);
}
