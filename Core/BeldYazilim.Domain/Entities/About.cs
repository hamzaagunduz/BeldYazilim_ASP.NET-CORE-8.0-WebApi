﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class About
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }    
        public string Title2 { get; set; }
        public string Content2 { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrl2 { get; set; }
    }
}