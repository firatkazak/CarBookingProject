using CarBooking.Application.Features.Mediator.Results.TestimonialResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.TestimonialQueries;
public class GetTestimonialByIdQuery : IRequest<GetTestimonialByIdQueryResult>
{
    public GetTestimonialByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
