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
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, List<GetTagByIdQueryResult>>
    {
        private readonly ITagRepository _tagRepository;

        public GetTagByIdQueryHandler(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task<List<GetTagByIdQueryResult>> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var tagResults = new List<GetTagByIdQueryResult>();

            // Makaleye ait tagleri repository kullanarak al
            var articleTags = _tagRepository.GetTagsByArticleId(request.ArticleId);

            // Tagleri GetTagByIdQueryResult nesnelerine dönüştür
            var result = new GetTagByIdQueryResult
            {
                ArticleID = request.ArticleId,
                TagIDs = articleTags.Select(at => at.TagID).ToList()
            };

            tagResults.Add(result);

            return tagResults;
        }


    }

}
