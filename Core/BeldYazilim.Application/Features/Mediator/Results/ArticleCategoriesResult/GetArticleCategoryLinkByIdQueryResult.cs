using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Results.ArticleCategories
{
    public class GetArticleCategoryLinkByIdQueryResult
    {
        public int ArticleCategoryLinkID { get; set; }

        public int ArticleID { get; set; }
        public int MainCategoryID { get; set; }
        public int SubcategoryID { get; set; }

        // Diğer özellikler ekleyebilirsiniz.
    }



}
