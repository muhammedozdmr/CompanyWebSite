using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CompanyWebSite.WebApp.Controllers
{
    public class FaqController : Controller
    {
        private readonly ILogger<FaqController> _logger;
        public FaqController(ILogger<FaqController> logger)
        {
            _logger = logger;
        }
        public async Task<IActionResult> Index(string languageCode = "tr")
        {
            try
            {
                using var client = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:5129/") // API Base Address
                };

                // API çağrısı
                var response = await client.GetAsync($"api/FaqAPI/GetAllFaqs?languageCode={languageCode}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var faqDtos = JsonConvert.DeserializeObject<List<FAQDto>>(result);
                    return View(faqDtos);
                }
                else
                {
                    ViewBag.ErrorMessage = $"API request failed with status code: {response.StatusCode}";
                    return View(new List<FAQDto>());
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(new List<FAQDto>());
            }
        }
    }
}
