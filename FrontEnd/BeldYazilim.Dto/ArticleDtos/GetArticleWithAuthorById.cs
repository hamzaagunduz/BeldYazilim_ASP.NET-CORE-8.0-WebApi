using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Dto.ArticleDtos
{
    public class GetArticleWithAuthorById
    {

            public int articleID { get; set; }
            public string title { get; set; }
            public string bigImageUrl { get; set; }
            public string imageUrl { get; set; }

            public DateTime creationTime { get; set; }

            public int clickCount { get; set; }
            public int articleAuthorID { get; set; }
            public string name { get; set; }
            public string role { get; set; }


    }
}
