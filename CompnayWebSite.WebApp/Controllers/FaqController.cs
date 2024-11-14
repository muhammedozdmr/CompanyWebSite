using Microsoft.AspNetCore.Mvc;

namespace CompnayWebSite.WebApp.Controllers
{
    public class FaqController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
