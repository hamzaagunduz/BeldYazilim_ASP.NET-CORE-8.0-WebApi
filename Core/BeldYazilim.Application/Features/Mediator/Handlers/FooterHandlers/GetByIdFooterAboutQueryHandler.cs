using BeldYazilim.Application.Features.Mediator.Queries.FooterQueries;
using BeldYazilim.Application.Features.Mediator.Queries.TagQueries;
using BeldYazilim.Application.Features.Mediator.Results.FooterResult;
using BeldYazilim.Application.Features.Mediator.Results.TagResult;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using BeldYazilim.Dto.FooterDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.FooterHandlers
{
    public class GetByIdFooterAboutQueryHandler : IRequestHandler<GetByIdFooterAboutQuery, GetByIdFooterAboutQueryResult>
    {
        private readonly IRepository<FooterAbout> _repository;

        public GetByIdFooterAboutQueryHandler(IRepository<FooterAbout> repository)
        {
            _repository = repository;
        }

        public async Task<GetByIdFooterAboutQueryResult> Handle(GetByIdFooterAboutQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.id);
            return new GetByIdFooterAboutQueryResult
            {
            Content=values.Content,
            FooterAboutID=values.FooterAboutID
            };
        }
    }
}
