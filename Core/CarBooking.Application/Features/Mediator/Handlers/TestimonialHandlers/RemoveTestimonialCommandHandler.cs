using CarBooking.Application.Features.Mediator.Commands.TestimonialCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.TestimonialHandlers;
public class RemoveTestimonialCommandHandler : IRequestHandler<RemoveTestimonialCommand>
{
    private readonly IRepository<Testimonial> _repository;
    public RemoveTestimonialCommandHandler(IRepository<Testimonial> repository)
    {
        _repository = repository;
    }
    public async Task Handle(RemoveTestimonialCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}
