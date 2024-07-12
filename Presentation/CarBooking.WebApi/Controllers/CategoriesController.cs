using CarBooking.Application.Features.CQRS.Commands.CategoryCommands;
using CarBooking.Application.Features.CQRS.Handlers.CategoryHandlers;
using CarBooking.Application.Features.CQRS.Queries.CategoryQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]

public class CategoriesController : ControllerBase
{
    private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
    private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
    private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
    private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;
    private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;

    public CategoriesController(CreateCategoryCommandHandler createCategoryCommandHandler, GetCategoryByIdQueryHandler getCategoryByIdQueryHandler, GetCategoryQueryHandler getCategoryQueryHandler, RemoveCategoryCommandHandler removeCategoryCommandHandler, UpdateCategoryCommandHandler updateCategoryCommandHandler)
    {
        _createCategoryCommandHandler = createCategoryCommandHandler;
        _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
        _getCategoryQueryHandler = getCategoryQueryHandler;
        _removeCategoryCommandHandler = removeCategoryCommandHandler;
        _updateCategoryCommandHandler = updateCategoryCommandHandler;
    }

    [HttpGet]
    public async Task<IActionResult> CategoryList()
    {
        var values = await _getCategoryQueryHandler.Handle();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategory(int id)
    {
        var value = await _getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
    {
        await _createCategoryCommandHandler.Handle(command);
        return Ok("Kategori bilgisi eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveCategory(int id)
    {
        await _removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(id));
        return Ok("Kategori bilgisi kaldırıldı.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
    {
        await _updateCategoryCommandHandler.Handle(command);
        return Ok("Kategori bilgisi güncellendi.");
    }
}
