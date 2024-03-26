using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Results.ArticleResult
{
    public class GetAllArticleWithAuthorAndCategoryQueryResult
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string CategoryName { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreationTime { get; set; }
        public int ClickCount { get; set; }

    }
}
