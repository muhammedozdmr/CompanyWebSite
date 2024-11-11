using CompanyWebSite.Dto;

namespace CompanyWebSite.Business.Services.Interface;

public interface INavbarItemService
{
    Task<IEnumerable<NavbarItemDto>> GetNavbarItemAllAsync(string languageCode);
    Task<NavbarItemDto> GetNavbarItemByIdAsync(int id);
    Task AddNavbarItemAsync(NavbarItemDto navbarItemDto);
    Task UpdateNavbarItemAsync(NavbarItemDto navbarItemDto);
    Task DeleteNavbarItemAsync(int id);
}
