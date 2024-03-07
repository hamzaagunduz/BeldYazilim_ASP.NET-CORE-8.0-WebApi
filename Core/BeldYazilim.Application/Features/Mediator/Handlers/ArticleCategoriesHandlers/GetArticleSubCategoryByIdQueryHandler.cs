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
    public class GetArticleSubCategoryByIdQueryHandler : IRequestHandler<GetArticleSubCategoryByIdQuery, GetArticleSubCategoryByIdQueryResult>
    {
        private readonly IRepository<Subcategory> _repository;

        public GetArticleSubCategoryByIdQueryHandler(IRepository<Subcategory> repository)
        {
            _repository = repository;
        }
        public async Task<GetArticleSubCategoryByIdQueryResult> Handle(GetArticleSubCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetArticleSubCategoryByIdQueryResult
            {
                SubCategoryID = values.SubCategoryID,
                Name = values.Name,
                ImageUrl=values.ImageUrl
            };
        }
    }
}
