using CarBooking.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBooking.Application.Features.Mediator.Queries.CarFeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CarFeaturesController : ControllerBase
{
    private readonly IMediator _mediator;

    public CarFeaturesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("CarFeatureListByCarId")]
    public async Task<IActionResult> CarFeatureListByCarId(int id)
    {
        var values = await _mediator.Send(new GetCarFeatureByCarIdQuery(id));
        return Ok(values);
    }

    [HttpGet("CarFeatureChangeAvailableToFalse")]
    public async Task<IActionResult> CarFeatureChangeAvailableToFalse(int id)
    {
        await _mediator.Send(new UpdateCarFeatureAvailableChangeToFalseCommand(id));
        return Ok("Güncelleme Yapıldı.");
    }

    [HttpGet("CarFeatureChangeAvailableToTrue")]
    public async Task<IActionResult> CarFeatureChangeAvailableToTrue(int id)
    {
        await _mediator.Send(new UpdateCarFeatureAvailableChangeToTrueCommand(id));
        return Ok("Güncelleme Yapıldı.");
    }

    [HttpPost]
    public async Task<IActionResult> CreateCarFeatureByCarID(CreateCarFeatureByCarCommand command)
    {
        await _mediator.Send(command);
        return Ok("Ekleme Yapıldı.");
    }
}
