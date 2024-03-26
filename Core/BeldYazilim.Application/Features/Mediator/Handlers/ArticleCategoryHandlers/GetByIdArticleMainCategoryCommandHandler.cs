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
    public class GetByIdArticleMainCategoryCommandHandler : IRequestHandler<GetArticleMainCategoryByIdQuery, GetArticleMainCategoryByIdQueryResult>
    {
        private readonly IRepository<ArticleMainCategory> _repository;

        public GetByIdArticleMainCategoryCommandHandler(IRepository<ArticleMainCategory> repository)
        {
            _repository = repository;
        }

        public async Task<GetArticleMainCategoryByIdQueryResult> Handle(GetArticleMainCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetArticleMainCategoryByIdQueryResult
            {
                ArticleMainCategoryID= values.ArticleMainCategoryID,
                Name= values.Name,
            };
        }
    }

    
}
