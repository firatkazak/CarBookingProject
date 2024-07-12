using CarBooking.Application.Features.CQRS.Results.BannerResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.BannerHandlers;
public class GetBannerQueryHandler
{
    private readonly IRepository<Banner> _repository;

    public GetBannerQueryHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetBannerQueryResult>> Handle()
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetBannerQueryResult
        {
            BannerID = x.BannerID,
            Description = x.Description,
            Title = x.Title,
            VideoDescription = x.VideoDescription,
            VideoUrl = x.VideoUrl,
        }).ToList();
    }
}
