using Microsoft.AspNetCore.Mvc;

namespace CompnayWebSite.WebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
