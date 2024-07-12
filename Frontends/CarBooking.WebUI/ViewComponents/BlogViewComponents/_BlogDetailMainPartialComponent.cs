using CarBooking.Dto.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.ViewComponents.BlogViewComponents;

public class _BlogDetailMainPartialComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;
    public _BlogDetailMainPartialComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage1 = await client.GetAsync($"https://localhost:7167/api/Blogs/" + id);
        if (responseMessage1.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage1.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<GetBlogByIdDto>(jsonData);
            return View(values);
        }
        return View();
    }
}
