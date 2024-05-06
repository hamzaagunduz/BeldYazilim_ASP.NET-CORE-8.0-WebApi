﻿using BeldYazilim.Application.Features.Mediator.Results.ArticleResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.ArticleQueries
{
	public class GetTopRatedCountArticlesQuery : IRequest<List<GetTopRatedArticlesQueryResult>>
	{
		public GetTopRatedCountArticlesQuery(int id)
		{
			this.id = id;
		}

		public int id { get; set; }
    }
}
