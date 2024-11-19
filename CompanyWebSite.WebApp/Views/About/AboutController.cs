using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.WebApp.Views.About
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
