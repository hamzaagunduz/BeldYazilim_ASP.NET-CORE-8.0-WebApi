using BeldYazilim.Application.Features.Mediator.Queries.ArticleCategoriesQueries;
using BeldYazilim.Application.Features.Mediator.Results.ArticleCategories;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.ArticleCategoriesHandlers
{
    public class GetArticleMainCategoryQueryHandler : IRequestHandler<GetArticleMainCategoryQuery, List<GetArticleMainCategoryQueryResult>>
    {
        private readonly IRepository<MainCategory> _repository;
        public GetArticleMainCategoryQueryHandler(IRepository<MainCategory> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetArticleMainCategoryQueryResult>> Handle(GetArticleMainCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetArticleMainCategoryQueryResult
            {
                MainCategoryID=x.MainCategoryID,
                Name=x.Name
            }).ToList();
        }
    }
}
