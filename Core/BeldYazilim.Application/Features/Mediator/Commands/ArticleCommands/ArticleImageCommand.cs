using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands
{
    public class ArticleImageCommand:IRequest
    {
        public int ArticleImageID { get; set; }
        public string ImageUrl { get; set; }
        public int ArticleID { get; set; }
    }
}
