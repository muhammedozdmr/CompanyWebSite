using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NavbarAndFooterAPIController : Controller
    {
        private readonly INavbarAndFooterService _navbarAndFooterService;
        public NavbarAndFooterAPIController(INavbarAndFooterService navbarAndFooterService)
        {
            _navbarAndFooterService = navbarAndFooterService;
        }

        [HttpGet]
        public async Task<IEnumerable<NavbarAndFooterDto>> GetAllNavbarsAndFooters(string languageCode = "tr")
        {
            return await _navbarAndFooterService.GetNavbarAndFooterAllAsync(languageCode);
        }
    }
}
