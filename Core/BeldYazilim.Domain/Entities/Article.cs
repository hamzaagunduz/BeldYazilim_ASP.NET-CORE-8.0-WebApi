using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }
        public int ClickCount { get; set; }
        public string BigImageUrl { get; set; }
        public int? Rating { get; set; }

        public List<ArticleCategory> ArticleCategorys { get; set;}
        public int ArticleAuthorID { get; set; }
        public ArticleAuthor ArticleAuthors { get; set;}
        public int ArticleCommentID { get; set; }
        public ArticleComment ArticleComments { get; set; }

        public int ArticleImageID { get; set; }
        public  ArticleImage ArticleImages { get; set; }

    }
}
