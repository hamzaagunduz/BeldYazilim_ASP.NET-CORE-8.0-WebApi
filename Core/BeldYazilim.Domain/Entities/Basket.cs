using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class Basket
    {
        public int BasketID { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        // Diğer özellikler...

        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
