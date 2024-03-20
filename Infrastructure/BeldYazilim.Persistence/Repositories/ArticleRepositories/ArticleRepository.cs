using BeldYazilim.Application.Interfaces.ArticleInterfaces;
using BeldYazilim.Domain.Entities;
using BeldYazilim.Persistence.Context;
using Microsoft.EntityFrameworkCore;


namespace BeldYazilim.Persistence.Repositories.ArticleRepositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly BeldYazilimContext _context;

        public ArticleRepository(BeldYazilimContext context)
        {
            _context = context;
        }

        public List<Article> GetAllArticlesWithAuthors()
        {
            var values = _context.Articles.Include(x => x.ArticleAuthor).ToList();
            return values;
        }
    }
}
