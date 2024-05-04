﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.FooterCommand
{
    public class UpdateFooterAboutCommand:IRequest
    {
        public int FooterAboutID { get; set; }
        public string Content { get; set; }
    }
}
