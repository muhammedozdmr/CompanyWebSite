using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeAPIController : Controller
    {
        private readonly IHomeService _homeService;
        public HomeAPIController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        public async Task<IEnumerable<HomeDto>> Index(string languageCode = "tr")
        {
            return await _homeService.GetHomeAllAsync(languageCode);
        }
    }
}
