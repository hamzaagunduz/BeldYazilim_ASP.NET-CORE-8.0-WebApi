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
    public class GetArticleAuthorQueryHandler : IRequestHandler<GetArticleAuthorQuery, List<GetArticleAuthorQueryResult>>
    {
        private readonly IRepository<ArticleAuthor> _repository;

        public GetArticleAuthorQueryHandler(IRepository<ArticleAuthor> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetArticleAuthorQueryResult>> Handle(GetArticleAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetArticleAuthorQueryResult
            {
               AppUserID = x.AppUserID,
               ArticleAuthorID = x.ArticleAuthorID,
               Name = x.Name,
               Role=x.Role,
               
            }).ToList();
        }
    }
}
