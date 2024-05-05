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
    public class GetLastAddArticlesQueryHandler : IRequestHandler<GetLastAddArticlesQuery, GetLastAddArticlesQueryResult>
    {
        private readonly IArticleRepository _repository;

        public GetLastAddArticlesQueryHandler(IArticleRepository repository)
        {
            _repository = repository;
        }

        public Task<GetLastAddArticlesQueryResult> Handle(GetLastAddArticlesQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetLatestArticles(1);
            return Task.FromResult(values.Select(x => new GetLastAddArticlesQueryResult
            {
                ArticleID = x.ArticleID,
                Title = x.Title,
                Content = x.Content,
                CreationTime = x.CreationTime,
                ClickCount = x.ClickCount,
                BigImageUrl = x.BigImageUrl,
                Rating = x.Rating,
                Name = x.ArticleAuthor.Name,
            }).FirstOrDefault());
        }
    }
}
