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

        public List<Article> GetLastFiveArticlesByCategory(int categoryId)
        {
            return _context.Articles
                .Where(a => a.ArticleMainCategoryID == categoryId)
                .OrderByDescending(a => a.CreationTime)
                .Take(5)
                .ToList();
        }

		public List<Article> GetRandomArticles(int count)
		{
			Random random = new Random();
			int totalArticleCount = _context.Articles.Count();

			// Toplam makale sayısı belirtilen sayıdan az ise, tüm makaleleri getir
			if (totalArticleCount <= count)
			{
				return _context.Articles.ToList();
			}
			else
			{
				// Tüm makalelerin ID'lerini al
				var allArticleIds = _context.Articles.Select(a => a.ArticleID).ToList();

				// Rastgele makale ID'leri seç
				HashSet<int> selectedIds = new HashSet<int>();
				while (selectedIds.Count < count)
				{
					int randomIdIndex = random.Next(allArticleIds.Count);
					int randomId = allArticleIds[randomIdIndex];
					if (!selectedIds.Contains(randomId))
					{
						selectedIds.Add(randomId);
					}
				}

				// Seçilen ID'lere göre makaleleri getir
				var selectedArticles = _context.Articles
					.Where(a => selectedIds.Contains(a.ArticleID))
					.ToList();

				return selectedArticles;
			}
		}

	}
}
