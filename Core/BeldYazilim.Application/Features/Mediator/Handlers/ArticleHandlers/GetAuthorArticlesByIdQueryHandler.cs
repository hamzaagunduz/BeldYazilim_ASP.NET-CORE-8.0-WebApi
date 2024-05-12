using BeldYazilim.Application.Features.Mediator.Queries.ArticleQueries;
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
    public class GetAuthorArticlesByIdQueryHandler : IRequestHandler<GetAuthorArticlesByIdQuery, List<GetAuthorArticlesByIdQueryResult>>
    {
        private readonly IArticleRepository _articleRepository;

        public GetAuthorArticlesByIdQueryHandler(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<List<GetAuthorArticlesByIdQueryResult>> Handle(GetAuthorArticlesByIdQuery request, CancellationToken cancellationToken)
        {
            var articles =  _articleRepository.GetArticlesByAuthor(request.AuthorId);
            return articles.Select(article => new GetAuthorArticlesByIdQueryResult
            {
                // Map Article properties to GetAuthorArticlesByIdQueryResult properties here
                ArticleID = article.ArticleID,
                Title = article.Title,
                Content = article.Content,
                CreationTime = article.CreationTime,
                ClickCount = article.ClickCount,
                BigImageUrl = article.BigImageUrl,
                Rating = article.Rating,
                Name = article.ArticleAuthor != null ? article.ArticleAuthor.Name : null,
                Role = article.ArticleAuthor != null ? article.ArticleAuthor.Role : null,
                ArticleAuthorID = article.ArticleAuthorID,
                FirstName=article.ArticleAuthor.AppUser.FirstName,
                Surname=article.ArticleAuthor.AppUser.Surname,
                ImageUrl=article.ArticleAuthor.AppUser.ImageUrl,
            }).ToList();
        }
    }
}
