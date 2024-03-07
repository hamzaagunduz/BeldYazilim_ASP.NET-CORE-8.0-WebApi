using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.ArticleCategories
{
    public class CreateSubcategoryCommand : IRequest<int>
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public int MainCategoryID { get; set; }
    }

}
