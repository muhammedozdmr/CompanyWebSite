using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CompanyWebSite.WebApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;
        public BlogController(ILogger<BlogController> logger)
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
                var response = await client.GetAsync($"api/BlogAPI/GetAllBlogs?languageCode={languageCode}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var blogDtos = JsonConvert.DeserializeObject<List<BlogDto>>(result);
                    return View(blogDtos);
                }
                else
                {
                    ViewBag.ErrorMessage = $"API request failed with status code: {response.StatusCode}";
                    return View(new List<BlogDto>());
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(new List<BlogDto>());
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
                var response = await client.GetAsync($"api/BlogAPI/GetBlogById?languageCode={languageCode}&id={id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var blogDto = JsonConvert.DeserializeObject<BlogDto>(result);
                    return View(blogDto);
                }
                else
                {
                    ViewBag.ErrorMessage = $"API request failed with status code: {response.StatusCode}";
                    return View(new BlogDto());
                }
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(new BlogDto());
            }
        } 
    } 
}
