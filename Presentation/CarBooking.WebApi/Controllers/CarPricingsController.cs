﻿using CarBooking.Application.Features.Mediator.Queries.CarPricingQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CarPricingsController : ControllerBase
{
    private readonly IMediator _mediator;
    public CarPricingsController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet("GetCarPricingWithCarList")]
    public async Task<IActionResult> GetCarPricingWithCarList()
    {
        var values = await _mediator.Send(new GetCarPricingWithCarQuery());
        return Ok(values);
    }

    [HttpGet("GetCarPricingWithTimePeriodList")]
    public async Task<IActionResult> GetCarPricingWithTimePeriodList()
    {
        var values = await _mediator.Send(new GetCarPricingWithTimePeriodQuery());
        return Ok(values);
    }

}
