using BeldYazilim.Application.Features.Mediator.Queries.TagQueries;
using BeldYazilim.Application.Features.Mediator.Results.TagResult;
using BeldYazilim.Application.Interfaces.TagInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.TagHandlers
{
    public class GetTagNameByIdQueryHandler : IRequestHandler<GetTagNameByIdQuery, List<GetTagNameByIdQueryResult>>
    {
        private readonly ITagRepository _tagRepository;

        public GetTagNameByIdQueryHandler(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public async Task<List<GetTagNameByIdQueryResult>> Handle(GetTagNameByIdQuery request, CancellationToken cancellationToken)
        {
            var tags = _tagRepository.GetTagsForArticle(request.id);

            var results = tags.Select(t => new GetTagNameByIdQueryResult
            {
                TagID = t.TagID,
                Name = t.Name
            }).ToList();

            return results;
        }
    }
}
