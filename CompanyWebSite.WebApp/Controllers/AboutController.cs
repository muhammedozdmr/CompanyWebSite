using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.WebApp.Controllers
{
    public class AboutController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
