using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.WebApp.Views.FAQ
{
    public class FaqController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
