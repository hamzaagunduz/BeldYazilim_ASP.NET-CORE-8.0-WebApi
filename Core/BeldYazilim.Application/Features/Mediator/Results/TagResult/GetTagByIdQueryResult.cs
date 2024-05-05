using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Results.TagResult
{
    public class GetTagByIdQueryResult
    {
        public int ArticleID { get; set; }
        public List<int> TagIDs { get; set; }
    }
}
