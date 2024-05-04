using BeldYazilim.Dto.AppUserDtos;
using BeldYazilim.Dto.ArticleCategoryDtos;
using BeldYazilim.Dto.ArticleDtos;

namespace BeldYazilim.WebUI.Models
{
    public class ArticleDetailModel
    {
        public GetAllArticleDto getAllArticleDto { get; set; }
        public GetArticleWithAuthorById getArticleWithAuthorById { get; set; }
        public GetUserWithRoleByIdDtos getUserWithRoleByIdDtos { get; set; }
        public List<GetTop3RatedArticles> getTop3RatedArticles { get; set; }
        public List<ResultMainCategoryDto> ResultMainCategoryDto { get; set; }
        public List<GetLast4ArticlesDto> getLast4ArticlesDto { get; set; }
        public List<GetAllTagDto> getAllTagDto { get; set; }
    }
}
