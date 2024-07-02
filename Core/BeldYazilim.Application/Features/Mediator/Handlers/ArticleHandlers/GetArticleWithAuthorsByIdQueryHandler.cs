using BeldYazilim.Application.Features.Mediator.Queries.ArticleCategoryQueries;
using BeldYazilim.Application.Features.Mediator.Queries.ArticleQueries;
using BeldYazilim.Application.Features.Mediator.Results.ArcileCategoryResult;
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
    public class GetArticleWithAuthorsByIdQueryHandler : IRequestHandler<GetArticleWithAuthorsByIdQuery, GetArticleWithAuthorsByIdQueryResult>
    {
        private readonly IArticleRepository _repository;

        public GetArticleWithAuthorsByIdQueryHandler(IArticleRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetArticleWithAuthorsByIdQueryResult> Handle(GetArticleWithAuthorsByIdQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetArticleWithAuthorsById(request.id);
            return new GetArticleWithAuthorsByIdQueryResult
            {
                ArticleID = value.ArticleID,
                Title = value.Title,
                CreationTime = value.CreationTime,
                ClickCount = value.ClickCount,
                ArticleAuthorID = value.ArticleAuthor.ArticleAuthorID,
                Name = value.ArticleAuthor.AppUser.FirstName,
                Role = value.ArticleAuthor.Role,
                bigImageUrl = value.BigImageUrl,
                ImageUrl = value.ArticleAuthor.AppUser.ImageUrl,
            };
        }
    }
}