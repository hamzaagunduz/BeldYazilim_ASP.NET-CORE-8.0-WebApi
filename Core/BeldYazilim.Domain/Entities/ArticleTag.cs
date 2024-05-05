using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class ArticleTag
    {
        public int ArticleTagID { get; set; }

        public int ArticleID { get; set; }
        public Article Article { get; set; }

        public int TagID { get; set; }
        public Tag Tag { get; set; }
    }
}
