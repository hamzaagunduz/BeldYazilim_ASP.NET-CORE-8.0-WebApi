using BeldYazilim.Application.Features.Mediator.Results.FeaturesResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.FeaturesQueries
{
    public class GetByIdFeaturesQuery:IRequest<GetByIdFeaturesQueryResult>
    {
        public GetByIdFeaturesQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
