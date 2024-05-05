using BeldYazilim.Application.Features.Mediator.Results.TagResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.TagQueries
{
    public class GetTagByTagIdQuery:IRequest<GetTagByTagIdQueryResult>
    {
        public GetTagByTagIdQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
