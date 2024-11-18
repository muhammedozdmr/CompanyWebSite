using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.WebApp.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
