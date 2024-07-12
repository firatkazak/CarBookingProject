using CarBooking.Dto.FooterAddressDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.ViewComponents.UILayoutViewComponents;

public class _FooterUILayoutPartialComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _FooterUILayoutPartialComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        HttpClient client = _httpClientFactory.CreateClient();
        HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:7167/api/FooterAddresses");
        if (responseMessage.IsSuccessStatusCode)
        {
            string jsonData = await responseMessage.Content.ReadAsStringAsync();
            List<ResultFooterAddressDto>? values = JsonConvert.DeserializeObject<List<ResultFooterAddressDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}
