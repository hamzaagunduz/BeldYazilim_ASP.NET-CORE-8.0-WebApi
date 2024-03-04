using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public  class Subcategory
    {
        public int SubCategoryID { get; set; }
        public string? ImageUrl { get; set; }
        public string Name { get; set; }

        public List<ArticleCategoryLink> ArticleCategoryLinks { get; set; }

        public int MainCategoryID { get; set; }
        public MainCategory MainCategory { get; set; }

    }
}
