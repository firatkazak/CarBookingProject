using CarBooking.Application.Features.Mediator.Commands.AuthorCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Authors.Mediator.Handlers.AuthorHandlers;
public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
{
    private readonly IRepository<Author> _repository;

    public UpdateAuthorCommandHandler(IRepository<Author> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.AuthorID);
        values.Description = request.Description;
        values.ImageUrl = request.ImageUrl;
        values.Name = request.Name;
        await _repository.UpdateAsync(values);
    }
}
