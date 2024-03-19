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
        public int MainCategoryID { get; set; }
        public string Name { get; set; }

    }
}
