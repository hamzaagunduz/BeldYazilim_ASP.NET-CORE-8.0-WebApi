using BeldYazilim.Application.Features.Mediator.Results.ArticleResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.ArticleQueries
{
	public class GetArticlesByCategoryPagedQuery:IRequest <List<GetArticlesByCategoryPagedQueryResult>>
	{
		public GetArticlesByCategoryPagedQuery(int categoryId, int pageNumber, int pageSize)
		{
			CategoryId = categoryId;
			PageNumber = pageNumber;
			PageSize = pageSize;
		}

		public int CategoryId { get; set; }
		public int PageNumber { get; set; }
		public int PageSize { get; set; }
	}
}

