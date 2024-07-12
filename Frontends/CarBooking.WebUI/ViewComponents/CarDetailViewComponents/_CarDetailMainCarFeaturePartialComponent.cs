using CarBooking.Dto.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.ViewComponents.CarDetailViewComponents;

public class _CarDetailMainCarFeaturePartialComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _CarDetailMainCarFeaturePartialComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        ViewBag.carid = id;
        var client = _httpClientFactory.CreateClient();
        var resposenMessage = await client.GetAsync($"https://localhost:7167/api/Cars/{id}");
        if (resposenMessage.IsSuccessStatusCode)
        {
            var jsonData = await resposenMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResultCarWithBrandsDtos>(jsonData);
            return View(values);
        }
        return View();
    }
}