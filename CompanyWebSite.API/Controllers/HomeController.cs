using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
