using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.TagCommands
{
    public class UpdateArticleTagCommand : IRequest
    {
        public int NewArticleId { get; }

        public UpdateArticleTagCommand(int newArticleId)
        {
            NewArticleId = newArticleId;
        }
    }
}
