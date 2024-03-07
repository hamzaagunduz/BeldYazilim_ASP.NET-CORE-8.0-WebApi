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
   public class GetArticleMainCategoryByIdQueryHandler : IRequestHandler<GetArticleMainCategoryByIdQuery, GetArticleMainCategoryByIdQueryResult>
    {
        private readonly IRepository<MainCategory> _repository;

        public GetArticleMainCategoryByIdQueryHandler(IRepository<MainCategory> repository)
        {
            _repository = repository;
        }
        public async Task<GetArticleMainCategoryByIdQueryResult> Handle(GetArticleMainCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetArticleMainCategoryByIdQueryResult
            {
              MainCategoryID=values.MainCategoryID,
              Name=values.Name,
            };
        }
    }
}
