using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.WebApp.Views.Blog
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
