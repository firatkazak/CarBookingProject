using CarBooking.Dto.CarPricingDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.ViewComponents.DashboardComponents;

public class _AdminDashboardCarPricingListPartialComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;
    public _AdminDashboardCarPricingListPartialComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        ViewBag.v1 = "Paketler";
        ViewBag.v2 = "Araç Fiyat Paketleri";
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7167/api/CarPricings/GetCarPricingWithTimePeriodList");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultCarPricingListWithModelDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}