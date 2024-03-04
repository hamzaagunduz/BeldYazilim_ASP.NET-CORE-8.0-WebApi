﻿using BeldYazilim.Application.Features.Mediator.Results.ArticleAuthorResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.ArticleAuthorQueries
{
    public class GetArticleAuthorByIdQuery:IRequest<GetArticleAuthorByIdQueryResult>
    {
        public GetArticleAuthorByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
