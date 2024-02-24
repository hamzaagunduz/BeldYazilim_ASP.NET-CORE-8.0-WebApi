using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class ProductSeller
    {
        public int ProductSellerID { get; set; }
        public int Profit { get; set; }
        public string TaxNumber { get; set; }


        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }

        public int ProductShopID { get; set; }
        public ProductShop ProductShop { get; set; }
    }
}
