using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto.LayoutDtos;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.API.Controllers
{
    public class FooterComponentAPIController : Controller
    {
        private readonly IFooterComponentService _footerComponentService;
        public FooterComponentAPIController(IFooterComponentService footerComponentService)
        {
            _footerComponentService = footerComponentService;
        }
        public async Task<IEnumerable<FooterComponentDto>> Index(string languageCode = "tr")
        {
            return await _footerComponentService.GetFooterComponentAllAsync(languageCode);
        }
    }
}
