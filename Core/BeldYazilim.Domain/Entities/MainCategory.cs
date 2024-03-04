using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class MainCategory
    {
        public int MainCategoryID { get; set; }
        public string Name { get; set; }

        public List<ArticleCategoryLink> ArticleCategoryLinks { get; set; }
    }
}
