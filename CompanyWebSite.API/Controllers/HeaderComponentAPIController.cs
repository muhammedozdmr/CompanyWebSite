using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto.LayoutDtos;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.API.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class HeaderComponentAPIController : Controller
    {

        //TODO: Apı verilerini kontrol et
        private readonly IHeaderComponentService _headerComponentService;
        public HeaderComponentAPIController(IHeaderComponentService headerComponentService)
        {
            _headerComponentService = headerComponentService;
        }

        [HttpGet]
        public async Task<IEnumerable<HeaderComponentDto>> Index(string languageCode = "tr")
        {
            return await _headerComponentService.GetHeaderComponentAllAsync(languageCode);
        }
    }
}
