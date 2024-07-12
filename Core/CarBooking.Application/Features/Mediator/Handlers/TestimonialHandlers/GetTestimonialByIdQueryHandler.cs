using CarBooking.Application.Features.Mediator.Queries.TestimonialQueries;
using CarBooking.Application.Features.Mediator.Results.TestimonialResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.TestimonialHandlers;
public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
{
    private readonly IRepository<Testimonial> _repository;

    public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
    {
        _repository = repository;
    }

    public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetTestimonialByIdQueryResult
        {
            Comment = values.Comment,
            ImageUrl = values.ImageUrl,
            Name = values.Name,
            TestimonialID = values.TestimonialID,
            Title = values.Title
        };
    }
}
