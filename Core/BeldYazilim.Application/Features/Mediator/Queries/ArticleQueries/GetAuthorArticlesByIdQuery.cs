using BeldYazilim.Application.Features.Mediator.Results.ArticleResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.ArticleQueries
{
    public class GetAuthorArticlesByIdQuery : IRequest<List<GetAuthorArticlesByIdQueryResult>>
    {
        public int AuthorId { get; }

        public GetAuthorArticlesByIdQuery(int authorId)
        {
            AuthorId = authorId;
        }
    }
}
