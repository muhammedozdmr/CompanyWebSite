using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CompanyWebSite.WebApp.ViewComponents;

public class NavbarFooterSidePanelViewComponent : ViewComponent
{
    private readonly HttpClient _httpClient;

    public NavbarFooterSidePanelViewComponent(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<IViewComponentResult>InvokeASync(string languageCode = "tr")
    {
        var response = await _httpClient.GetAsync($"api/NavbarFooterSidePanelAPI/Index?languageCode={languageCode}");
        if(response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadAsStringAsync();
            var navbarFooterSidePanelDtos = JsonConvert.DeserializeObject<List<NavbarFooterSidePanelDto>>(result);
            return View(navbarFooterSidePanelDtos);
        }
        else
        {
            ViewBag.ErrorMessage = $"API request failed with status code: {response.StatusCode}";
            return View(new List<NavbarFooterSidePanelDto>()); //Boş model döndür
        }
    }
}
