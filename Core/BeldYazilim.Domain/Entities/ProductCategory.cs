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
        public string? ImageUrl { get; set; }
        public string Title { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
