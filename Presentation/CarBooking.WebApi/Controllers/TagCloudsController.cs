using CarBooking.Application.Features.Mediator.Commands.TagCloudCommands;
using CarBooking.Application.Features.Mediator.Queries.TagCloudQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TagCloudsController : ControllerBase
{
    private readonly IMediator _mediator;
    public TagCloudsController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> TagCloudList()
    {
        var values = await _mediator.Send(new GetTagCloudQuery());
        return Ok(values);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetTagCloud(int id)
    {
        var value = await _mediator.Send(new GetTagCloudByIdQuery(id));
        return Ok(value);
    }
    [HttpPost]
    public async Task<IActionResult> CreateTagCloud(CreateTagCloudCommand command)
    {
        await _mediator.Send(command);
        return Ok("Etiket Bulutu başarıyla eklendi");
    }
    [HttpDelete]
    public async Task<IActionResult> RemoveTagCloud(int id)
    {
        await _mediator.Send(new RemoveTagCloudCommand(id));
        return Ok("Etiket Bulutu başarıyla silindi");
    }
    [HttpPut]
    public async Task<IActionResult> UpdateTagCloud(UpdateTagCloudCommand command)
    {
        await _mediator.Send(command);
        return Ok("Etiket Bulutu başarıyla güncellendi");
    }

    [HttpGet("GetTagClodByBlogId")]
    public async Task<IActionResult> GetTagClodByBlogId(int id)
    {
        var values = await _mediator.Send(new GetTagCloudByBlogIdQuery(id));
        return Ok(values);
    }
}
