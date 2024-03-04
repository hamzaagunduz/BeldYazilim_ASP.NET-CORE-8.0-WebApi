using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class ProductCategory
    {
        public int ProductCategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<ProductCategoryLink> ProductCategoryLinks { get; set; }

    }
}
