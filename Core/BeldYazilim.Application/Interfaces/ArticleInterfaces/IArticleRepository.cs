using BeldYazilim.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Interfaces.ArticleInterfaces
{
    public interface IArticleRepository
    {
        public List<Article> GetAllArticlesWithAuthors();
    }
}
