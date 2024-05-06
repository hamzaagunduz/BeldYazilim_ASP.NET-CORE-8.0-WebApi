using BeldYazilim.Application.Features.Mediator.Queries.ArticleQueries;
using BeldYazilim.Application.Features.Mediator.Results.ArticleResult;
using BeldYazilim.Application.Interfaces.ArticleInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.ArticleHandlers
{
    public class GetLastFiveArticlesByCategoryQueryHandler : IRequestHandler<GetLastFiveArticlesByCategoryQuery, List<GetLastFiveArticlesByCategoryQueryResult>>
    {
        private readonly IArticleRepository _repository;

        public GetLastFiveArticlesByCategoryQueryHandler(IArticleRepository repository)
        {
            _repository = repository;
        }
        public Task<List<GetLastFiveArticlesByCategoryQueryResult>> Handle(GetLastFiveArticlesByCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetLastFiveArticlesByCategory(request.id);

            return Task.FromResult(values.Select(x => new GetLastFiveArticlesByCategoryQueryResult
            {
                ArticleID = x.ArticleID,
                Title = x.Title,
                Content = x.Content,
                CreationTime = x.CreationTime,
                ClickCount = x.ClickCount,
                BigImageUrl = x.BigImageUrl,
                Rating = x.Rating,
                
            }).ToList());
        }
    }
}
