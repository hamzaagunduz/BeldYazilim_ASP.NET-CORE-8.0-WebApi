﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class ProductImage
    {
        public int ProductImageID { get; set; }
        public string ImageUrl { get; set; }
        // Diğer özellikler...

        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
