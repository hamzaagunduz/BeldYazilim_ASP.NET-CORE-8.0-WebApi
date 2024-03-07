using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Results.ArticleCategories
{
    public class GetArticleSubCategoryQueryResult
    {
        public int SubCategoryID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
