using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Results.ArticleResult
{
    public class GetArticleWithAuthorsByIdQueryResult
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string bigImageUrl { get; set; }
        public string? ImageUrl { get; set; }

        public DateTime CreationTime { get; set; }
        public int ClickCount { get; set; }
        public int ArticleAuthorID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
