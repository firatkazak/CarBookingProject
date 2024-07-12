using CarBooking.Dto.CarDescriptionDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.ViewComponents.CarDetailViewComponents;

public class _CarDetailCarDescriptionByCarIdPartialComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;
    public _CarDetailCarDescriptionByCarIdPartialComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        ViewBag.carid = id;
        var client = _httpClientFactory.CreateClient();
        var resposenMessage = await client.GetAsync($"https://localhost:7167/api/CarDescriptions?id=" + id);
        if (resposenMessage.IsSuccessStatusCode)
        {
            var jsonData = await resposenMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResultCarDescriptionByCarIdDto>(jsonData);
            return View(values);
        }
        return View();
    }
}