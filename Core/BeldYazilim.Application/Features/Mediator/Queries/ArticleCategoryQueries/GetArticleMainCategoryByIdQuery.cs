using BeldYazilim.Application.Features.Mediator.Results.ArcileCategoryResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.ArticleCategoryQueries
{
    public  class GetArticleMainCategoryByIdQuery : IRequest<GetArticleMainCategoryByIdQueryResult>
    {
        public GetArticleMainCategoryByIdQuery(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }
    }
}
