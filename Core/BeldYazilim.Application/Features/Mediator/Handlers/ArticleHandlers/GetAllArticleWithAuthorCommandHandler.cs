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
    public class GetAllArticleWithAuthorCommandHandler : IRequestHandler<GetAllArticleWithAuthorQuery, List<GetAllArticleWithAuthorQueryResult>>
    {
        private readonly IArticleRepository _repository;

        public GetAllArticleWithAuthorCommandHandler(IArticleRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllArticleWithAuthorQueryResult>> Handle(GetAllArticleWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values =  _repository.GetAllArticlesWithAuthors();

            return values.Select(x => new GetAllArticleWithAuthorQueryResult
            {
                ArticleID = x.ArticleID,
                Title = x.Title,
                Content = x.Content,
                CreationTime = x.CreationTime,
                ClickCount = x.ClickCount,
                BigImageUrl = x.BigImageUrl,
                Rating = x.Rating,
                ArticleAuthorID = x.ArticleAuthorID,
                MainCategoryId = x.ArticleMainCategoryID,
                Name = x.ArticleAuthor.Name,
                Role = x.ArticleAuthor.Role
            }).ToList();
        }
    }
}
