using CompanyWebSite.Dto.LayoutDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CompanyWebSite.WebApp.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly HttpClient _httpClient;
        public FooterViewComponent(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IViewComponentResult> InvokeAsync(string languageCode = "tr")
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
            };
            using var client = new HttpClient(handler)
            {
                BaseAddress = new Uri("http://localhost:5129/") // API Base Address
            };
            var response = await client.GetAsync($"api/FooterComponentAPI/Index?languageCode={languageCode}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var footerDtos = JsonConvert.DeserializeObject<List<FooterComponentDto>>(result);
                return View(footerDtos);
            }
            else
            {
                ViewBag.ErrorMessage = $"API request failed with status code: {response.StatusCode}";
                return View(new List<FooterComponentDto>()); //Boş model döndür
            }
        }
    }
}
