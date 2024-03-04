using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.ArticleAuthorCommands
{
    public class UpdateArticleAuthorCommand:IRequest
    {
        public int ArticleAuthorID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int ArticleID { get; set; }
        public int AppUserID { get; set; }

    }
}
