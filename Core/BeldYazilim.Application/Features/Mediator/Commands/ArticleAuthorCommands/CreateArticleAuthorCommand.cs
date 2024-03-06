using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.ArticleAuthorCommands
{
    public class CreateArticleAuthorCommand:IRequest<int>
    {
        public int AppUserID { get; set; }

        public string Name { get; set; }
        public string Role { get; set; }

    }
}
