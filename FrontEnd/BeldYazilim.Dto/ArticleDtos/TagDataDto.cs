using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Dto.ArticleDtos
{
    public class TagDataDto
    {
        public int ArticleID { get; set; }
        public List<int> TagID { get; set; }
    }
}
