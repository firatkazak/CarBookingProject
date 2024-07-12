using CarBooking.Application.Enums;
using CarBooking.Application.Features.Mediator.Commands.AppUserCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.AppUserHandlers;
public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
{
	private readonly IRepository<AppUser> _repository;
	public CreateAppUserCommandHandler(IRepository<AppUser> repository)
	{
		_repository = repository;
	}
	public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
	{
		await _repository.CreateAsync(new AppUser
		{
			Password = request.Password,
			Username = request.Username,
			AppRoleId = (int)RolesType.Member,
			Email = request.Email,
			Name = request.Name,
			Surname = request.Surname
		});
	}
}
