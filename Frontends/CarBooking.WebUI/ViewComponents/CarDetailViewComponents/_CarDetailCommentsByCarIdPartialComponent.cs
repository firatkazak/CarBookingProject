using CarBooking.Dto.ReviewDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.ViewComponents.CarDetailViewComponents;

public class _CarDetailCommentsByCarIdPartialComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;
    public _CarDetailCommentsByCarIdPartialComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        ViewBag.carid = id;
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7167/api/Reviews?id=" + id);
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultReviewByCarIdDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}