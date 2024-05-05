using BeldYazilim.Application.Features.Mediator.Queries.FooterQueries;
using BeldYazilim.Application.Features.Mediator.Queries.TagQueries;
using BeldYazilim.Application.Features.Mediator.Results.FooterResult;
using BeldYazilim.Application.Features.Mediator.Results.TagResult;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.FooterHandlers
{
    public class GetFooterAboutQueryHandler:IRequestHandler<GetFooterAboutQuery, List<GetFooterAboutQueryResult>>
    {

        private readonly IRepository<FooterAbout> _repository;

        public GetFooterAboutQueryHandler(IRepository<FooterAbout> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAboutQueryResult>> Handle(GetFooterAboutQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAboutQueryResult
            {
               Content=x.Content,

            }).ToList();
        }
    }
}
