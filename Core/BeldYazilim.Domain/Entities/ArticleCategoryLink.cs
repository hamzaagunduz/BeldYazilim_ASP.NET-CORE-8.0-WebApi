using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class ArticleCategoryLink
    {
        public int ArticleCategoryLinkID { get; set; }

        public int ArticleID { get; set; }
        public Article Article { get; set; }

        public int MainCategoryID { get; set; }
        public MainCategory MainCategory { get; set; }

        public int SubcategoryID { get; set; }
        public Subcategory Subcategory { get; set; }
    }
}
