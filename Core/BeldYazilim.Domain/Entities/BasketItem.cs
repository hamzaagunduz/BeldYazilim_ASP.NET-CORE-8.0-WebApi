using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class BasketItem
    {
        public int BasketItemID { get; set; }
        public int Quantity { get; set; }
        // Diğer özellikler...

        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int BasketID { get; set; }
        public Basket Basket { get; set; }

    }
}
