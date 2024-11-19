using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.WebApp.Views.Contact
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
