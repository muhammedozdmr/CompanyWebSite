using CompanyWebSite.Dto;
using CompanyWebSite.Dto.LayoutDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CompanyWebSite.WebApp.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly HttpClient _httpClient;

        public HeaderViewComponent(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IViewComponentResult> InvokeAsync(string languageCode = "tr")
        {
            using var client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:5129/") // API Base Address
            };
            var response = await client.GetAsync($"api/HeaderComponentAPI/Index?languageCode={languageCode}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var headerDtos = JsonConvert.DeserializeObject<List<HeaderComponentDto>>(result);
                return View(headerDtos);
            }
            else
            {
                ViewBag.ErrorMessage = $"API request failed with status code: {response.StatusCode}";
                return View(new List<HeaderComponentDto>()); //Boş model döndür
            }
        }
    }
}
