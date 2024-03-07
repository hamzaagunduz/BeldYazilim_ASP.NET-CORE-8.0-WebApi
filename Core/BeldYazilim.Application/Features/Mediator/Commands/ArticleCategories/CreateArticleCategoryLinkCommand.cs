using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.ArticleCategories
{
    public class CreateArticleCategoryLinkCommand : IRequest<int>
    {
        public int ArticleID { get; set; }
        public int MainCategoryID { get; set; }
        public int SubcategoryID { get; set; }
    }
}
