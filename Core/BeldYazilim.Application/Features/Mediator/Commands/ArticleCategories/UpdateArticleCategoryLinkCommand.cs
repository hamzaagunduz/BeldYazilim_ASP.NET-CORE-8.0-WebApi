
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Commands.ArticleCategories
{
    public class UpdateArticleCategoryLinkCommand : IRequest
    {
        public int ArticleCategoryLinkID { get; set; }
        public int UpdatedArticleID { get; set; }
        public int UpdatedMainCategoryID { get; set; }
        public int UpdatedSubcategoryID { get; set; }
        // Diğer güncellenmesi gereken özellikler
    }

}
