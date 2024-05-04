using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.FooterCommand
{
    public class CreateFooterAboutCommand:IRequest
    {
        public string Content { get; set; }
    }
}
