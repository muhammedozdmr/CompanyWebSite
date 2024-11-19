using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto.LayoutDtos;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HeaderSidePanelComponentAPIController : Controller
    {
        private readonly IHeaderSidePanelComponentService _headerSidePanelComponentService;
        public HeaderSidePanelComponentAPIController(IHeaderSidePanelComponentService headerSidePanelComponentService)
        {
            _headerSidePanelComponentService = headerSidePanelComponentService;
        }

        [HttpGet]
        public async Task<IEnumerable<HeaderSidePanelComponentDto>> Index(string languageCode = "tr")
        {
            return await _headerSidePanelComponentService.GetHeaderSidePanelComponentAllAsync(languageCode);
        }
    }
}
