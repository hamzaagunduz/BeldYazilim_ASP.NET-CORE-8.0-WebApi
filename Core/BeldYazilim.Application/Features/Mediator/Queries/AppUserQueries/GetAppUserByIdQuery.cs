using BeldYazilim.Application.Features.Mediator.Results.AppUserResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.AppUserQueries
{
    public class GetAppUserByIdQuery:IRequest<GetAppUserByIdQueryResult>
    {
        public GetAppUserByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
