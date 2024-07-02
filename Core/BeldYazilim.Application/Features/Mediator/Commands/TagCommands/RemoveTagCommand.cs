using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.TagCommands
{
    public class RemoveTagCommand:IRequest
    {
        public RemoveTagCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
