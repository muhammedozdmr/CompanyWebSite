using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.WebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
