using CompanyWebSite.Business.Helpers;
using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Newtonsoft.Json;
using System.Text;

namespace CompanyWebSite.WebApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
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
                var response = await client.GetAsync($"api/ContactAPI/Index?languageCode={languageCode}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var contactDtos = JsonConvert.DeserializeObject<List<ContactDto>>(result);
                    return View(contactDtos);
                }
                else
                {
                    ViewBag.ErrorMessage = $"API request failed with status code: {response.StatusCode}";
                    return View(new List<ContactDto>());
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(new List<ContactDto>());
            }
        }

        public async Task<IActionResult> SendMessage([FromBody] ContactFormDto contactFormDto)
        {
            try
            {
                using var client = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:5129/") // API Base Address
                };

                // API çağrısı
                var response = await client.PostAsync($"api/ContactAPI/AddContactFormFromContact", new StringContent(JsonConvert.SerializeObject(contactFormDto), Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return Ok(result);
                }
                else
                {
                    return BadRequest($"API request failed with status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
