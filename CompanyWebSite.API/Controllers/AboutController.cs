using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public async Task<IEnumerable<AboutDto>> GetAllAbouts(string languageCode = "tr")
        {
            return await _aboutService.GetAboutAllAsync(languageCode);
        }
    }
}
