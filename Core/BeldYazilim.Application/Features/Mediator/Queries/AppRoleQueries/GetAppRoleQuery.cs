using BeldYazilim.Application.Features.Mediator.Results.AppRoleResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.AppRoleQueries
{
    public class GetAppRoleQuery:IRequest<List<GetAppRoleQueryResult>>
    {
    }
}
