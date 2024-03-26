using BeldYazilim.Application.Features.Mediator.Handlers.ArticleCategoryHandlers;
using BeldYazilim.Application.Features.Mediator.Queries.ArticleCategoryQueries;
using BeldYazilim.Application.Features.Mediator.Queries.ArticleQueries;
using BeldYazilim.Application.Features.Mediator.Results.ArcileCategoryResult;
using BeldYazilim.Application.Features.Mediator.Results.ArticleResult;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BeldYazilim.Application.Features.Mediator.Handlers.ArticleCategoryHandlers
{
    public class GetArticleMainCategoryCommandHandler : IRequestHandler<GetArticleMainCategoryQuery,List<GetArticleMainCategoryQueryResult>>
    {
        private readonly IRepository<ArticleMainCategory> _repository;

        public GetArticleMainCategoryCommandHandler(IRepository<ArticleMainCategory> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetArticleMainCategoryQueryResult>> Handle(GetArticleMainCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetArticleMainCategoryQueryResult
            {
               Name=x.Name,
               ArticleMainCategoryID=x.ArticleMainCategoryID
            }).ToList();
        }
    }
}
