using CarBooking.Application.Features.Mediator.Results.SocialMediaResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.SocialMediaQueries;
public class GetSocialMediaByIdQuery : IRequest<GetSocialMediaByIdQueryResult>
{
    public GetSocialMediaByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
