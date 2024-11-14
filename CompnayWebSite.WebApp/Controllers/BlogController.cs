using Microsoft.AspNetCore.Mvc;

namespace CompnayWebSite.WebApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
