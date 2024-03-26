using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.ArticleCategoryCommands
{
    public class RemoveMainCategoryArticleCommand:IRequest
    {
        public RemoveMainCategoryArticleCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }
}
