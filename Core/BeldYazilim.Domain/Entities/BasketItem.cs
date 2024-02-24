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

        public int Amount { get; set; }
        public int BasketID { get; set; }
        public Basket Basket{ get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }

    }
}
