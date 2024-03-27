using BeldYazilim.Application.Features.Mediator.Queries.AppUserQueries;
using BeldYazilim.Application.Features.Mediator.Results.AppUserResult;
using BeldYazilim.Application.Features.Mediator.Results.ArticleResult;
using BeldYazilim.Application.Interfaces.AppUserInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class GetAllUsersWithRoleQueryHandler : IRequestHandler<GetAllUsersWithRoleQuery, List<GetAllUsersWithRoleQueryResult>>
    {
        private readonly IAppUserRepository _repository;

        public GetAllUsersWithRoleQueryHandler(IAppUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllUsersWithRoleQueryResult>> Handle(GetAllUsersWithRoleQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAllUsersWithRole();

            return values.Select(x => new GetAllUsersWithRoleQueryResult
            {
                Id = x.Id,
                FirstName = x.FirstName,
                Email=x.Email,
                Surname=x.Surname,
                Role=x.ArticleAuthor.Role,
            }).ToList();
        }
    }
}
