using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public  class ArticleCategory
    {
        public int ArticleCategoryID { get; set; }
        public string? ImageUrl { get; set; }
        public string Title { get; set; }
        public int ArticleID { get; set; }
        public Article Article { get; set; }
        public int ArticleParentCategoryID { get; set; }
        public ArticleParentCategory ArticleParentCategory { get; set; }

    }
}
