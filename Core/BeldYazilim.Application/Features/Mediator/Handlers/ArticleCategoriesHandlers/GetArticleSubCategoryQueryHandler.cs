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
    public class GetArticleSubCategoryQueryHandler : IRequestHandler<GetArticleSubCategoryQuery, List<GetArticleSubCategoryQueryResult>>
    {
        private readonly IRepository<Subcategory> _repository;
        public GetArticleSubCategoryQueryHandler(IRepository<Subcategory> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetArticleSubCategoryQueryResult>> Handle(GetArticleSubCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetArticleSubCategoryQueryResult
            {
                SubCategoryID = x.SubCategoryID,
                Name = x.Name,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}
