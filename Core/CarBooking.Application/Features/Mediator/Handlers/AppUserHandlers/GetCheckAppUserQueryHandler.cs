using CarBooking.Application.Features.Mediator.Queries.AppUserQueries;
using CarBooking.Application.Features.Mediator.Results.AppUserResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.AppUserHandlers;
public class GetCheckAppUserQueryHandler : IRequestHandler<GetCheckAppUserQuery, GetCheckAppUserQueryResult>
{
	private readonly IRepository<AppUser> _appUserRepository;
	private readonly IRepository<AppRole> _appRoleRepository;

	public GetCheckAppUserQueryHandler(IRepository<AppUser> appUserRepository, IRepository<AppRole> appRoleRepository)
	{
		_appUserRepository = appUserRepository;
		_appRoleRepository = appRoleRepository;
	}

	public async Task<GetCheckAppUserQueryResult> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
	{
		var values = new GetCheckAppUserQueryResult();
		var user = await _appUserRepository.GetByFilterAsync(x => x.Username == request.Username && x.Password == request.Password);
		if (user == null)
		{
			values.IsExist = false;
		}
		else
		{
			values.IsExist = true;
			values.Username = user.Username;
			values.Role = (await _appRoleRepository.GetByFilterAsync(x => x.AppRoleId == user.AppRoleId)).AppRoleName;
			values.Id = user.AppUserId;
		}
		return values;
	}
}
