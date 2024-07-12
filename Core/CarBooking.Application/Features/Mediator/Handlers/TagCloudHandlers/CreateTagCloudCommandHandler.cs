using CarBooking.Application.Features.Mediator.Commands.TagCloudCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.TagCloudHandlers;
public class CreatePricingCommandHandler : IRequestHandler<CreateTagCloudCommand>
{
    private readonly IRepository<TagCloud> _repository;
    public CreatePricingCommandHandler(IRepository<TagCloud> repository)
    {
        _repository = repository;
    }
    public async Task Handle(CreateTagCloudCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new TagCloud
        {
            Title = request.Title,
            BlogID = request.BlogID
        });
    }
}