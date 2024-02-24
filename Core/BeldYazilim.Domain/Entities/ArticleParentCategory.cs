using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class ArticleParentCategory
    {
        public int ArticleParentCategoryID { get; set; }
        public string Name { get; set; }

        public List<ArticleCategory> ArticleCategories { get; set; }
    }
}
