using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CompanyWebSite.WebApp.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ILogger<ServiceController> _logger;
        public ServiceController(ILogger<ServiceController> logger)
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
                var response = await client.GetAsync($"api/ServiceAPI/GetAllServices?languageCode={languageCode}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var serviceDtos = JsonConvert.DeserializeObject<List<ServiceDto>>(result);
                    return View(serviceDtos);
                }
                else
                {
                    ViewBag.ErrorMessage = $"API request failed with status code: {response.StatusCode}";
                    return View(new List<ServiceDto>());
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(new List<ServiceDto>());
            }
        }

        public async Task<IActionResult> GetById(string languageCode, int id)
        {
            try
            {
                using var client = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:5129/") // API Base Address
                };

                // API çağrısı
                var response = await client.GetAsync($"api/ServiceAPI/GetServiceById?languageCode={languageCode}&id={id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var serviceDto = JsonConvert.DeserializeObject<ServiceDto>(result);
                    return View(serviceDto);
                }
                else
                {
                    ViewBag.ErrorMessage = $"API request failed with status code: {response.StatusCode}";
                    return View(new ServiceDto());
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(new ServiceDto());
            }
        }
    }
}
