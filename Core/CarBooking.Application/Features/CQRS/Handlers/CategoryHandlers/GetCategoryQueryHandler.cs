using CarBooking.Application.Features.CQRS.Results.CategoryResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.CategoryHandlers;
public class GetCategoryQueryHandler
{
    private readonly IRepository<Category> _repository;

    public GetCategoryQueryHandler(IRepository<Category> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCategoryQueryResult>> Handle()
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetCategoryQueryResult
        {
            CategoryID = x.CategoryID,
            Name = x.Name,
        }).ToList();
    }

}
