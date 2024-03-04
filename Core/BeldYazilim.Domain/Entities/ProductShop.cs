using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class ProductShop
    {
        public int ProductShopID { get; set; }
        public string ProducyShopName { get; set; }

        //public List<Product> Products { get; set; }
        public int ProductSellerID { get; set; }
        public ProductSeller ProductSeller { get; set; }

        public List<Product> Products { get; set; }

    }
}
