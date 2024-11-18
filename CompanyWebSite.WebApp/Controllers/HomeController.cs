using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using CompanyWebSite.WebApp.Models;

namespace CompanyWebSite.WebApp.Controllers
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
            try
            {
                using var client = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:5129/") // API Base Address
                };

                // API çağrısı
                var response = await client.GetAsync($"api/HomeAPI/Index?languageCode={languageCode}");
        
                if (response.IsSuccessStatusCode)
                {
                    // JSON yanıtını deserialize et
                    var result = await response.Content.ReadAsStringAsync();
                    var homeDtos = JsonConvert.DeserializeObject<List<HomeDto>>(result);
                    
                    var navbarFooterSidePanelResponse = await client.GetAsync($"api/NavbarFooterSidePanelAPI/Index?languageCode={languageCode}");
                    if(navbarFooterSidePanelResponse.IsSuccessStatusCode)
                    {
                        var navbarFooterSidePanelResult = await navbarFooterSidePanelResponse.Content.ReadAsStringAsync();
                        var navbarFooterSidePanelDtos = JsonConvert.DeserializeObject<List<NavbarFooterSidePanelDto>>(navbarFooterSidePanelResult);
                        ViewBag.NavbarFooterSidePanels = navbarFooterSidePanelDtos;
                    }
                    else
                    {
                        ViewBag.ErrorMessage = $"API request failed with status code: {navbarFooterSidePanelResponse.StatusCode}";
                    }
                    // Veri varsa View'e gönder
                    return View(homeDtos);
                }
                else
                {
                    // Hata durumunda log ve uygun yanıt
                    ViewBag.ErrorMessage = $"API request failed with status code: {response.StatusCode}";
                    return View(new List<HomeDto>()); // Boş liste döndür
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda log veya hata sayfasına yönlendirme
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(new List<HomeDto>()); // Boş liste döndür
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
