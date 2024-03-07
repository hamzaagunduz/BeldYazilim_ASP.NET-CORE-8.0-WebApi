using BeldYazilim.Application.Features.Mediator.Queries.ArticleCategoriesQueries;
using BeldYazilim.Application.Features.Mediator.Results.ArticleAuthorResult;
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
    public class GetArticleCategoryLinkQueryHandler : IRequestHandler<GetArticleCategoryLinkQuery, List<GetArticleCategoryLinkQueryResult>>
    {
        private readonly IRepository<ArticleCategoryLink> _repository;
        public GetArticleCategoryLinkQueryHandler(IRepository<ArticleCategoryLink> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetArticleCategoryLinkQueryResult>> Handle(GetArticleCategoryLinkQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetArticleCategoryLinkQueryResult
            {
                ArticleID=x.ArticleID,
                SubcategoryID=x.SubcategoryID,
                MainCategoryID=x.MainCategoryID,
                ArticleCategoryLinkID = x.ArticleCategoryLinkID
            }).ToList();
        }
    }
}
