using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class ArticleComment
    {
        public int ArticleCommentID { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Article> Articles { get; set; }
    }
}
