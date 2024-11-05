using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")
    public class ServiceController : Controller
    {
        private
        public IActionResult Index()
        {
            return View();
        }
    }
}
