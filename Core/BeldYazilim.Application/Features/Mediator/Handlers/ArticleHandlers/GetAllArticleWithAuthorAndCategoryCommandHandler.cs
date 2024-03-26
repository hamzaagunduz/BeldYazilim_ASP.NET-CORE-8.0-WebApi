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
    public class GetAllArticleWithAuthorAndCategoryCommandHandler : IRequestHandler<GetAllArticleWithAuthorAndCategoryQuery, List<GetAllArticleWithAuthorAndCategoryQueryResult>>
    {
        private readonly IArticleRepository _repository;

        public GetAllArticleWithAuthorAndCategoryCommandHandler(IArticleRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllArticleWithAuthorAndCategoryQueryResult>> Handle(GetAllArticleWithAuthorAndCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAllArticlesWithAuthorsAndCategory();

            return values.Select(x => new GetAllArticleWithAuthorAndCategoryQueryResult
            {
                ArticleID = x.ArticleID,
                Title = x.Title,
                CreationTime = x.CreationTime,
                ClickCount = x.ClickCount,
                AuthorName = x.ArticleAuthor.Name,
                CategoryName=x.ArticleMainCategory.Name
            }).ToList();
        }
    }
}
