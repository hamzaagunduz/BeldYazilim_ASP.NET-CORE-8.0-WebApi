using BeldYazilim.Application.Features.Mediator.Queries.AppUserQueries;
using BeldYazilim.Application.Features.Mediator.Results.AppUserResult;
using BeldYazilim.Application.Interfaces.AppUserInterfaces;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.AppUserHandlers
{
	public class GetUsersWithAdminRoleQueryHandler : IRequestHandler<GetUsersWithAdminRoleQuery, List<GetUsersWithAdminRoleQueryResult>>
	{
		private readonly IAppUserRepository _repository;

		public GetUsersWithAdminRoleQueryHandler(IAppUserRepository repository)
		{
			_repository = repository;
		}

		public async Task<List<GetUsersWithAdminRoleQueryResult>> Handle(GetUsersWithAdminRoleQuery request, CancellationToken cancellationToken)
		{
			var users = await _repository.GetUsersWithAdminRoleAsync();

			var results = users.Select(user => new GetUsersWithAdminRoleQueryResult
			{
				FirstName = user.FirstName,
				Surname = user.Surname,
				About = user.About,
				ImageUrl = user.ImageUrl,
				Role = user.ArticleAuthor.Role
			}).ToList();

			return results;
		}
	}
}