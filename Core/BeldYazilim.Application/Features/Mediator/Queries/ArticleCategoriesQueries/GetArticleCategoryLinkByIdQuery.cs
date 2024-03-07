﻿using BeldYazilim.Application.Features.Mediator.Results.ArticleCategories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.ArticleCategoriesQueries
{
    public class GetArticleCategoryLinkByIdQuery:IRequest<GetArticleCategoryLinkByIdQueryResult>
    {
        public GetArticleCategoryLinkByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
