﻿using BeldYazilim.Application.Features.Mediator.Results.ArticleCategories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.ArticleCategoriesQueries
{
    public class GetArticleSubCategoryQuery : IRequest<List<GetArticleSubCategoryQueryResult>>
    {
        public GetArticleSubCategoryQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
