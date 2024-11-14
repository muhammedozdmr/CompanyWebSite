using Microsoft.AspNetCore.Mvc;

namespace CompnayWebSite.WebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
