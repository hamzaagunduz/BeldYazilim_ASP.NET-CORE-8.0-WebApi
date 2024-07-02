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
	internal class GetTopRatedCountArticlesQueryHandler : IRequestHandler<GetTopRatedArticlesQuery, List<GetTopRatedArticlesQueryResult>>
	{
		private readonly IArticleRepository _repository;

		public GetTopRatedCountArticlesQueryHandler(IArticleRepository repository)
		{
			_repository = repository;
		}
		public Task<List<GetTopRatedArticlesQueryResult>> Handle(GetTopRatedArticlesQuery request, CancellationToken cancellationToken)
		{
			var values = _repository.GetTopRatedArticles(3);

			return Task.FromResult(values.Select(x => new GetTopRatedArticlesQueryResult
			{
				ArticleID = x.ArticleID,
				Title = x.Title,
				CreationTime = x.CreationTime,
				ClickCount = x.ClickCount,
				BigImageUrl = x.BigImageUrl,
				Rating = x.Rating,
				Name = x.ArticleAuthor.Name,
			}).ToList());
		}
	}
}
