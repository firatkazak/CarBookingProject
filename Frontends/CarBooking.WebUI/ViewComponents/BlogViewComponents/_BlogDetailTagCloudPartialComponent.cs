using CarBooking.Dto.TagCloudDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.ViewComponents.BlogViewComponents;

public class _BlogDetailTagCloudPartialComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;
    public _BlogDetailTagCloudPartialComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        ViewBag.blogid = id;
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7167/api/TagClouds/GetTagClodByBlogId/" + id);
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<GetByBlogIdTagCloudDto>(jsonData);
            return View(values);
        }
        return View();
    }
}
