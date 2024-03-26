using BeldYazilim.Application.Features.Mediator.Results.ArcileCategoryResult;
using BeldYazilim.Application.Features.Mediator.Results.ArticleAuthorResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.ArticleCategoryQueries
{
    public class GetArticleMainCategoryQuery : IRequest<List<GetArticleMainCategoryQueryResult>>
    {
    }
}
