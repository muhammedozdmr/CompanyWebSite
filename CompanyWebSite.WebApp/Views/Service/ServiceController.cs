using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.WebApp.Views.Service
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
