using Microsoft.AspNetCore.Mvc;

namespace CompnayWebSite.WebApp.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
