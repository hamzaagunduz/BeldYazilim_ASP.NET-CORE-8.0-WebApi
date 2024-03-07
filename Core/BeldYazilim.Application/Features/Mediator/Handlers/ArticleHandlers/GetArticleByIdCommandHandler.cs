using BeldYazilim.Application.Features.Mediator.Queries.ArticleAuthorQueries;
using BeldYazilim.Application.Features.Mediator.Queries.ArticleQueries;
using BeldYazilim.Application.Features.Mediator.Results.ArticleAuthorResult;
using BeldYazilim.Application.Features.Mediator.Results.ArticleResult;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.ArticleCommandHandlers
{
    public class GetArticleByIdCommandHandler:IRequestHandler<GetArticleByIdQuery,GetArticleByIdQueryResult>
    {
        private readonly IRepository<Article> _repository;

        public GetArticleByIdCommandHandler(IRepository<Article> repository)
        {
            _repository = repository;
        }
        public async Task<GetArticleByIdQueryResult> Handle(GetArticleByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetArticleByIdQueryResult
            {
                ArticleID = values.ArticleID,
                Title = values.Title,
                Content = values.Content,
                CreationTime = values.CreationTime,
                ClickCount = values.ClickCount,
                BigImageUrl = values.BigImageUrl,
                Rating = values.Rating,
                ArticleAuthorID = values.ArticleAuthorID
            };
        }
    }
}
