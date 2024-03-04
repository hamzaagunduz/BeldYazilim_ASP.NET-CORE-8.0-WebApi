using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class ProductCategoryLink
    {
        public int ProductCategoryLinkID { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int ProductCategoryID { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }

}
