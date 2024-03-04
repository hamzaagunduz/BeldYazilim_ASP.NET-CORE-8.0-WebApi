using BeldYazilim.Application.Features.Mediator.Queries.ArticleAuthorQueries;
using BeldYazilim.Application.Features.Mediator.Results.ArticleAuthorResult;
using BeldYazilim.Application.Interfaces;
using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.ArticleAuthorHandlers
{
    public class GetArticleAuthorByIdQueryHandler : IRequestHandler<GetArticleAuthorByIdQuery, GetArticleAuthorByIdQueryResult>
    {
        private readonly IRepository<ArticleAuthor> _repository;

        public GetArticleAuthorByIdQueryHandler(IRepository<ArticleAuthor> repository)
        {
            _repository = repository;
        }
        public async Task<GetArticleAuthorByIdQueryResult> Handle(GetArticleAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetArticleAuthorByIdQueryResult
            {
                AppUserID = values.AppUserID,
                ArticleAuthorID = values.ArticleAuthorID,
                ArticleID = values.ArticleID,
                Name = values.Name,
                Role = values.Role,
            };
        }
    }
}
