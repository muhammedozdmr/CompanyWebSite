using CompanyWebSite.Dto;
using CompnayWebSite.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CompnayWebSite.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(string languageCode = "tr")
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7106/");
            HttpResponseMessage response = await client.GetAsync($"api/HomeAPI/Index/");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                List<HomeDto> homeDtos = JsonConvert.DeserializeObject<List<HomeDto>>(result);
                return View(homeDtos);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
