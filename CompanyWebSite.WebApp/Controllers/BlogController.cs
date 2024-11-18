using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.WebApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
