using BeldYazilim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.TagCommands
{
    public class CreateTagCommand:IRequest
    {

        public int ArticleID { get; set; }
        public List<int> TagID { get; set; }
    }
}
