using CarBooking.Application.Features.Mediator.Commands.TestimonialCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.TestimonialHandlers;
public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
{
    private readonly IRepository<Testimonial> _repository;

    public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.TestimonialID);
        values.Comment = request.Comment;
        values.ImageUrl = request.ImageUrl;
        values.Name = request.Name;
        values.TestimonialID = request.TestimonialID;
        values.Title = request.Title;
        await _repository.UpdateAsync(values);
    }
}
