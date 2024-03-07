using BeldYazilim.Application.Features.Mediator.Queries.ArticleQueries;
using BeldYazilim.Application.Features.Mediator.Queries.ArticleQueries;
using BeldYazilim.Application.Features.Mediator.Results.ArticleResult;
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
    public class GetArticleCommandHandler : IRequestHandler<GetArticleQuery, List<GetArticleQueryResult>>
    {
        private readonly IRepository<Article> _repository;

        public GetArticleCommandHandler(IRepository<Article> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetArticleQueryResult>> Handle(GetArticleQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetArticleQueryResult
            {
                ArticleID = x.ArticleID,
                Title = x.Title,
                Content = x.Content,
                CreationTime = x.CreationTime,
                ClickCount = x.ClickCount,
                BigImageUrl = x.BigImageUrl,
                Rating = x.Rating,
                ArticleAuthorID = x.ArticleAuthorID

            }).ToList();
        }
        }
    }

