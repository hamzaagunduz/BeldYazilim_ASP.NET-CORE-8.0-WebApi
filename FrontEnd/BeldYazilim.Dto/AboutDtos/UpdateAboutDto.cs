﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Dto.AboutDtos
{
    public class UpdateAboutDto
    {
        public int aboutID { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string title2 { get; set; }
        public string content2 { get; set; }
        public string imageUrl { get; set; }
        public string imageUrl2 { get; set; }
        public IFormFile Photo { get; set; }
        public IFormFile Photo2 { get; set; }
    }
}
