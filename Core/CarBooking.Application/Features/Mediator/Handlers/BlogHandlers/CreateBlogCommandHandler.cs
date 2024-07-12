using CarBooking.Application.Features.Mediator.Commands.BlogCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.BlogHandlers;
public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
{
    private readonly IRepository<Blog> _repository;

    public CreateBlogCommandHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Blog
        {
            AuthorID = request.AuthorID,
            CategoryID = request.CategoryID,
            CoverImageUrl = request.CoverImageUrl,
            CreatedDate = request.CreatedDate,
            Description = request.Description,
            Title = request.Title,
        });
    }
}
