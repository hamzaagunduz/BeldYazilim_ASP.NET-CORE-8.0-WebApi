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
	public class GetLast5ArticlesQueryHandler : IRequestHandler<GetLast5ArticlesQuery, List<GetLatestArticlesQueryResult>>
	{
		private readonly IArticleRepository _repository;

		public GetLast5ArticlesQueryHandler(IArticleRepository repository)
		{
			_repository = repository;
		}
		public Task<List<GetLatestArticlesQueryResult>> Handle(GetLast5ArticlesQuery request, CancellationToken cancellationToken)
		{
			var values = _repository.GetLatestArticles(5);

			return Task.FromResult(values.Select(x => new GetLatestArticlesQueryResult
			{
				ArticleID = x.ArticleID,
				Title = x.Title,
				Content = x.Content,
				CreationTime = x.CreationTime,
				ClickCount = x.ClickCount,
				BigImageUrl = x.BigImageUrl,
				Rating = x.Rating,
				Name = x.ArticleAuthor.Name,
			}).ToList());
		}
	
	}
}
