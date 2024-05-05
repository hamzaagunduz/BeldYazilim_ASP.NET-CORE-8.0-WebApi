using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.ArticleCategoryCommands
{
    public class UpdateMainCategoryArticleCommand:IRequest
    {
        public int articleMainCategoryID { get; set; }
        public string name { get; set; }

    }
}
