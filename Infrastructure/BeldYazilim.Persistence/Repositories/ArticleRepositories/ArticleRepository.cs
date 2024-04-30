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

        public List<Article> GetAllArticlesWithAuthorsAndCategory()
        {
            var values = _context.Articles.Include(x => x.ArticleAuthor).Include(y => y.ArticleMainCategory).ToList();
            return values;
        }


        public Article GetArticleWithAuthorsById(int articleId)
        {
            var article = _context.Articles
                .Include(x => x.ArticleAuthor)
                    .ThenInclude(aa => aa.AppUser)
                .FirstOrDefault(x => x.ArticleID == articleId);

            return article;
        }

        public List<Article> GetTopRatedArticles(int count)
        {
            var topRatedArticles = _context.Articles
                .OrderByDescending(a => a.Rating) // Rating'e göre azalan sırayla sırala
                .Take(count) // İstenilen sayıda makale al
                .Include(a => a.ArticleAuthor) // Makalelerle birlikte yazar bilgisini yükle
                .ToListAsync().Result; // Asenkron metodu senkron şekilde çalıştırmak için Result özelliğini kullan

            return topRatedArticles;
        }

        public List<Article> GetLatestArticles(int count)
        {
            var latestArticles = _context.Articles
                .OrderByDescending(a => a.CreationTime) // Oluşturulma zamanına göre azalan sırayla sırala
                .Take(count) // İstenilen sayıda makale al
                .Include(a => a.ArticleAuthor) // Makalelerle birlikte yazar bilgisini yükle
                .ToList();

            return latestArticles;
        }


    }
}
