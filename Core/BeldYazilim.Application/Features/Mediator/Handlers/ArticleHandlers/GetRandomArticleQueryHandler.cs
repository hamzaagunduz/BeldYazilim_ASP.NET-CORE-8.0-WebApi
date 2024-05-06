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
	public class GetRandomArticleQueryHandler:IRequestHandler<GetRandomArticleQuery,List<GetRandomArticleQueryResult>>
	{
		private readonly IArticleRepository _repository;

		public GetRandomArticleQueryHandler(IArticleRepository repository)
		{
			_repository = repository;
		}
		public Task<List<GetRandomArticleQueryResult>> Handle(GetRandomArticleQuery request, CancellationToken cancellationToken)
		{
			var values = _repository.GetRandomArticles(request.id);

			return Task.FromResult(values.Select(x => new GetRandomArticleQueryResult
			{
				ArticleID = x.ArticleID,
				Title = x.Title,
				Content = x.Content,
				CreationTime = x.CreationTime,
				ClickCount = x.ClickCount,
				BigImageUrl = x.BigImageUrl,
				Rating = x.Rating,
			}).ToList());
		}
	}
}

