using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.TagCommands
{
    public class UpdateTagCommand:IRequest
    {
        public string Name { get; set; }
        public int TagID { get; set; }
    }
}
