using CarBooking.Application.Features.Mediator.Commands.TestimonialCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.TestimonialHandlers;
public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand>
{
    private readonly IRepository<Testimonial> _repository;

    public CreateTestimonialCommandHandler(IRepository<Testimonial> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Testimonial
        {
            Comment = request.Comment,
            ImageUrl = request.ImageUrl,
            Name = request.Name,
            Title = request.Title,
        });
    }
}
