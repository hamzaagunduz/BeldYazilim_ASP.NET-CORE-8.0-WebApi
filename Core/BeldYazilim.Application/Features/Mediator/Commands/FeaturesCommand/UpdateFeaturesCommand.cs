﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.FeaturesCommand
{
    public class UpdateFeaturesCommand:IRequest
    {
        public int FeatureID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Title2 { get; set; }
        public string Content2 { get; set; }
        public string Title3 { get; set; }
        public string Content3 { get; set; }
    }
}
