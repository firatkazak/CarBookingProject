using CarBooking.Application.Features.Mediator.Commands.BlogCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.BlogHandlers;
public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
{
    private readonly IRepository<Blog> _repository;

    public UpdateBlogCommandHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.BlogID);
        values.AuthorID = request.AuthorID;
        values.BlogID = request.BlogID;
        values.CategoryID = request.CategoryID;
        values.CoverImageUrl = request.CoverImageUrl;
        values.CreatedDate = request.CreatedDate;
        values.Description = request.Description;
        values.Title = request.Title;
        await _repository.UpdateAsync(values);
    }
}
