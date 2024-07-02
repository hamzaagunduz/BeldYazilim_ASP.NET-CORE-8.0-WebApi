using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace BeldYazilim.Dto.ArticleDtos
{
    public class GetAllArticleDto
    {

            public int articleID { get; set; }
            public string title { get; set; }
            public string content { get; set; }
            public int mainCategoryId { get; set; }
            public int articleMainCategoryID { get; set; }
            public DateTime creationTime { get; set; }
            public int clickCount { get; set; }
            public string bigImageUrl { get; set; }
            public int rating { get; set; }
            public int articleAuthorID { get; set; }




    }
}
