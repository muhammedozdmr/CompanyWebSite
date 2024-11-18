using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.WebApp.Controllers
{
    public class FaqController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
