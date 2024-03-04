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

        public int ArticleID { get; set; }
        public Article Article { get; set; }
    }
}
