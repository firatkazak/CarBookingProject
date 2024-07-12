using CarBooking.Dto.AboutDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.ViewComponents.AboutViewComponents;

public class _AboutUsPartialComponent : ViewComponent
{
    public readonly IHttpClientFactory _HttpClientFactory;

    public _AboutUsPartialComponent(IHttpClientFactory httpClientFactory)
    {
        _HttpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _HttpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7167/api/Abouts");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}
