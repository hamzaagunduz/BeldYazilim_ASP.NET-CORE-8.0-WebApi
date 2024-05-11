using BeldYazilim.Application.Features.Mediator.Results.AboutResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.AboutQueries
{
    public class GetAboutByIdQuery:IRequest<GetAboutByIdQueryResult>
    {
        public GetAboutByIdQuery(int id)
        {
            this.id = id;
        }

        public int  id { get; set; }
    }
}
