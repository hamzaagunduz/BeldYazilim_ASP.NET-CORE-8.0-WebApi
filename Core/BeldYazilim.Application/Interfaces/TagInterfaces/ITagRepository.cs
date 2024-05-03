using BeldYazilim.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Interfaces.TagInterfaces
{
    public interface ITagRepository
    {
        public List<ArticleTag> GetTagsByArticleId(int articleId);
        Task UpdateArticleTags(int newArticleId);


    }
}
