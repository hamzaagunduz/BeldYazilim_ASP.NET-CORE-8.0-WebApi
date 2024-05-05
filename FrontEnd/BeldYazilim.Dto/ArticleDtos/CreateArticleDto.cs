using Microsoft.AspNetCore.Http;


namespace BeldYazilim.Dto.ArticleDtos
{
    public class CreateArticleDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int MainCategoryId { get; set; }
        public IFormFile Photo { get; set; }

    }
}
