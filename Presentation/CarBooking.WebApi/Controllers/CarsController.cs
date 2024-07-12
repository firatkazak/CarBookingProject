using CarBooking.Application.Features.CQRS.Commands.CarCommands;
using CarBooking.Application.Features.CQRS.Handlers.CarHandlers;
using CarBooking.Application.Features.CQRS.Queries.CarQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CarsController : ControllerBase
{
    private readonly CreateCarCommandHandler _createCarCommandHandler;
    private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
    private readonly GetCarQueryHandler _getCarQueryHandler;
    private readonly RemoveCarCommandHandler _removeCarCommandHandler;
    private readonly UpdateCarCommandHandler _updateCarCommandHandler;
    private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;
    private readonly GetLast5CarWithBrandQueryHandler _getLast5CarWithBrandQueryHandler;

    public CarsController(CreateCarCommandHandler createCarCommandHandler, GetCarByIdQueryHandler getCarByIdQueryHandler, GetCarQueryHandler getCarQueryHandler, RemoveCarCommandHandler removeCarCommandHandler, UpdateCarCommandHandler updateCarCommandHandler, GetCarWithBrandQueryHandler getCarWithBrandQueryHandler, GetLast5CarWithBrandQueryHandler getLast5CarWithBrandQueryHandler)
    {
        _createCarCommandHandler = createCarCommandHandler;
        _getCarByIdQueryHandler = getCarByIdQueryHandler;
        _getCarQueryHandler = getCarQueryHandler;
        _removeCarCommandHandler = removeCarCommandHandler;
        _updateCarCommandHandler = updateCarCommandHandler;
        _getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
        _getLast5CarWithBrandQueryHandler = getLast5CarWithBrandQueryHandler;
    }

    [HttpGet]
    public async Task<IActionResult> CarList()
    {
        var values = await _getCarQueryHandler.Handle();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCar(int id)
    {
        var value = await _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCar(CreateCarCommand command)
    {
        await _createCarCommandHandler.Handle(command);
        return Ok("Araba bilgisi eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveCar(int id)
    {
        await _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
        return Ok("Araba bilgisi kaldırıldı.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
    {
        await _updateCarCommandHandler.Handle(command);
        return Ok("Araba bilgisi güncellendi.");
    }

    [HttpGet("GetCarWithBrand")]
    public IActionResult GetCarWithBrand()
    {
        var values = _getCarWithBrandQueryHandler.Handle();
        return Ok(values);
    }

    [HttpGet("GetLast5CarWithBrand")]
    public IActionResult GetLast5CarWithBrand()
    {
        var values = _getLast5CarWithBrandQueryHandler.Handle();
        return Ok(values);
    }

}
