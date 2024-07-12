using CarBooking.Application.Features.Mediator.Queries.RentACarQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RentACarsController : ControllerBase
{
    private readonly IMediator _mediator;
    public RentACarsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetRentACarListByLocation(int locationID, bool available)
    {
        GetRentACarQuery getRentACarQuery = new GetRentACarQuery()
        {
            Available = available,
            LocationID = locationID
        };
        var values = await _mediator.Send(getRentACarQuery);
        return Ok(values);
    }
}
