using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class Tag
    {
        public int TagID { get; set; }
        public string Name { get; set; }

        public List<ArticleTag> ArticleTags { get; set; }
    }
}
