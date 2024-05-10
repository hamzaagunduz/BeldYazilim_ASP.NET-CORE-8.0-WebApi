
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
	public class GetArticlesByCategoryPagedQueryHandler : IRequestHandler<GetArticlesByCategoryPagedQuery, List<GetArticlesByCategoryPagedQueryResult>>
	{
		private readonly IArticleRepository _repository;

		public GetArticlesByCategoryPagedQueryHandler(IArticleRepository repository)
		{
			_repository = repository;
		}
		public Task<List<GetArticlesByCategoryPagedQueryResult>> Handle(GetArticlesByCategoryPagedQuery request, CancellationToken cancellationToken)
		{
			var values = _repository.GetArticlesByCategoryPaged(request.CategoryId,request.PageNumber,request.PageSize);

			return Task.FromResult(values.Select(x => new GetArticlesByCategoryPagedQueryResult
			{
				ArticleID = x.ArticleID,
				Title = x.Title,
				Content = x.Content,
				CreationTime = x.CreationTime,
				ClickCount = x.ClickCount,
				BigImageUrl = x.BigImageUrl,
				Rating = x.Rating,
				ArticleMainCategoryID=x.ArticleMainCategoryID,
				ArticleAuthorID=x.ArticleAuthorID,
			}).ToList());
		}
	}
}
