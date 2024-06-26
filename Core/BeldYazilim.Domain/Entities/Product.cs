﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string BigImageUrl { get; set; }
        public int Price { get; set; }
        public int ProductShopID { get; set; }
        public ProductShop ProductShop { get; set; }
        public List<ProductCategoryLink> ProductCategoryLinks { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}
