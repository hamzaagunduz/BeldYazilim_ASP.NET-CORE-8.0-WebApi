using BeldYazilim.Application.Features.Mediator.Results.FooterResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.FooterQueries
{
    public class GetFooterAboutQuery:IRequest<List<GetFooterAboutQueryResult>>
    {
    }
}
