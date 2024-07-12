using CarBooking.Dto.RentACarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.Controllers;
public class RentACarListController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;
    public RentACarListController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IActionResult> Index(int id)
    {

        var locationID = TempData["locationID"];

        id = int.Parse(locationID.ToString());

        ViewBag.locationID = locationID;

        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7167/api/RentACars?locationID={id}&available=true");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<FilterRentACarDto>>(jsonData);
            return View(values);
        }
        return View();
    }

}
