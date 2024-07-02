using BeldYazilim.Application.Features.Mediator.Results.AppUserResult;
using BeldYazilim.Application.Features.Mediator.Results.ArticleResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.AppUserQueries
{
    public class GetAllUsersWithRoleQuery : IRequest<List<GetAllUsersWithRoleQueryResult>>
    {
    }
}
