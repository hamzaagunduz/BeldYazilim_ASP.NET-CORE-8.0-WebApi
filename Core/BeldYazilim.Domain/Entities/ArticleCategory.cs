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
        public string Image { get; set; }
        public string Title { get; set; }
        public int ArticleID { get; set; }
        public Article Article { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
