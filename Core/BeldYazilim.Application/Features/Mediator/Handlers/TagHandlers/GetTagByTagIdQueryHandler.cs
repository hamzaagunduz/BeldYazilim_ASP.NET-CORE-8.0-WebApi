using BeldYazilim.Application.Features.Mediator.Queries.ArticleCategoryQueries;
using BeldYazilim.Application.Features.Mediator.Queries.TagQueries;
using BeldYazilim.Application.Features.Mediator.Results.ArcileCategoryResult;
using BeldYazilim.Application.Features.Mediator.Results.TagResult;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using BeldYazilim.Dto.ArticleDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.TagHandlers
{
    public class GetTagByTagIdQueryHandler : IRequestHandler<GetTagByTagIdQuery, GetTagByTagIdQueryResult>
    {
        private readonly IRepository<Tag> _repository;

        public GetTagByTagIdQueryHandler(IRepository<Tag> repository)
        {
            _repository = repository;
        }

        public async Task<GetTagByTagIdQueryResult> Handle(GetTagByTagIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.id);
            return new GetTagByTagIdQueryResult
            {
                TagID = values.TagID,
                Name = values.Name,
            };
        }
    }
}
