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
    public class GetArticleCategoryLinkByIdQueryHandler : IRequestHandler<GetArticleCategoryLinkByIdQuery, GetArticleCategoryLinkByIdQueryResult>
    {
        private readonly IRepository<ArticleCategoryLink> _repository;

        public GetArticleCategoryLinkByIdQueryHandler(IRepository<ArticleCategoryLink> repository)
        {
            _repository = repository;
        }
        public async Task<GetArticleCategoryLinkByIdQueryResult> Handle(GetArticleCategoryLinkByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetArticleCategoryLinkByIdQueryResult
            {
                ArticleCategoryLinkID = values.ArticleCategoryLinkID,
                ArticleID = values.ArticleID,
                MainCategoryID = values.MainCategoryID,
                SubcategoryID = values.SubcategoryID,
            };
        }
    }
}
