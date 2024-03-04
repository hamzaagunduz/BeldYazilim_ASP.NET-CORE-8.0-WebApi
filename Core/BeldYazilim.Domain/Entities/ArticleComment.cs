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
        public string CommentText { get; set; }
        public string? CommentTitle { get; set; }

        public int ArticleID { get; set; }
        public Article Article { get; set; }

        public int? AppUserID { get; set; }
        public AppUser CommentedBy { get; set; }
    }
}
