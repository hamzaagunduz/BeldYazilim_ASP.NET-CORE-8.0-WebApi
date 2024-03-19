using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Domain.Entities
{
    public class ArticleAuthor
    {
        public int ArticleAuthorID{ get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        
        public List<Article> Articles { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }

    }
}
