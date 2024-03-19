using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public  class ArticleMainCategory
    {
        public int ArticleMainCategoryID { get; set; }
        public string Name { get; set; }
        public List<Article> Articles { get; set; }

    }
}
