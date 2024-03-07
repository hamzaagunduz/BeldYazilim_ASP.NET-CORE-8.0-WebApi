using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.ArticleCategories
{
    public class CreateMainCategoryCommand : IRequest<int>
    {
        public string Name { get; set; }
    }

}
