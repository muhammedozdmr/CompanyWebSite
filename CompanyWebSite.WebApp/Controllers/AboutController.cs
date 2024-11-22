using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CompanyWebSite.WebApp.Controllers
{
    public class AboutController : Controller
    {
        private readonly ILogger<AboutController> _logger;

        public AboutController(ILogger<AboutController> logger)
        {
            _logger = logger;
        }

        public async Task <IActionResult> Index(string languageCode = "tr")
        {
            try
            {
                using var client = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:5129/") // API Base Address
                };

                // API çağrısı
                var response = await client.GetAsync($"api/AboutAPI/Index?languageCode={languageCode}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var aboutDtos = JsonConvert.DeserializeObject<List<AboutDto>>(result);
                    return View(aboutDtos);
                }
                else
                {
                    ViewBag.ErrorMessage = $"API request failed with status code: {response.StatusCode}";
                    return View(new List<AboutDto>());
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(new List<AboutDto>());
            }
        }
    }
}
