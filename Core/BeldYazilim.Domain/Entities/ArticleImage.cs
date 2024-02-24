using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class ArticleImage
    {
        public int ArticleImageID { get; set; }
        public string ImageUrl { get; set; }

        public List<Article> Articles { get; set; }
    }
}
