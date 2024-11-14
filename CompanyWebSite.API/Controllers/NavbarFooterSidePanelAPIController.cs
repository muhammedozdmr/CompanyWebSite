using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NavbarFooterSidePanelAPIController : Controller
    {
        private readonly INavbarFooterSidePanelService _navbarFooterSidePanelService;
        public NavbarFooterSidePanelAPIController(INavbarFooterSidePanelService navbarFooterSidePanelService)
        {
            _navbarFooterSidePanelService = navbarFooterSidePanelService;
        }

        [HttpGet]
        public async Task<IEnumerable<NavbarFooterSidePanelDto>> GetAllNavbarsFootersSidePanels(string languageCode = "tr")
        {
            return await _navbarFooterSidePanelService.GetNavbarFooterSidePanelAllAsync(languageCode);
        }
    }
}
