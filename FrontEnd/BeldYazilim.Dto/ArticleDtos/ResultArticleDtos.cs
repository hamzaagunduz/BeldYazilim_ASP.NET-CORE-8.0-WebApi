using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Dto.ArticleDtos
{
    public class ResultArticleDtos
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string CategoryName { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreationTime { get; set; }
        public int ClickCount { get; set; }

    }
}
