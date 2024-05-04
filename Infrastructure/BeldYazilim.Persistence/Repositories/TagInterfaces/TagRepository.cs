using BeldYazilim.Application.Interfaces.TagInterfaces;
using BeldYazilim.Domain.Entities;
using BeldYazilim.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;


namespace BeldYazilim.Persistence.Repositories.TagInterfaces
{
    public class TagRepository : ITagRepository
    {

        private readonly BeldYazilimContext _context;
        public TagRepository(BeldYazilimContext context)
        {
            _context = context;
        }

        public List<ArticleTag> GetTagsByArticleId(int articleId)
        {
            return _context.ArticleTags
                .Where(at => at.ArticleID == articleId)
                .ToList();
        }

        public async Task UpdateArticleTags(int newArticleId)
        {
            int oldArticleId = 55;
            // Yeni ArticleID ile ilgili ArticleTag kayıtlarını oluşturun
            var newArticleTags = _context.ArticleTags
                                            .Where(at => at.ArticleID == oldArticleId)
                                            .Select(at => new ArticleTag { ArticleID = newArticleId, TagID = at.TagID })
                                            .ToList();

            // Eski ArticleID ile ilişkili ArticleTag kayıtlarını silin
            var oldArticleTags = _context.ArticleTags.Where(at => at.ArticleID == oldArticleId).ToList();
            _context.ArticleTags.RemoveRange(oldArticleTags);

            // Yeni ArticleTag kayıtlarını ekleyin
            _context.ArticleTags.AddRange(newArticleTags);

            // Değişiklikleri veritabanına kaydet
            await _context.SaveChangesAsync();
        }

        public List<Tag> GetTagsForArticle(int articleId)
        {
            // Makaleye ait etiketleri almak için LINQ sorgusu
            var tags = _context.ArticleTags
                .Where(at => at.ArticleID == articleId)
                .Select(at => at.Tag)
                .ToList();

            return tags;
        }

    }
}
