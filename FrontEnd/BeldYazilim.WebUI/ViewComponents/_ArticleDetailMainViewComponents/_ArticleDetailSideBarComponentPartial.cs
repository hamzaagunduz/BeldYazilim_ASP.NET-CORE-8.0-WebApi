using BeldYazilim.Dto.AppUserDtos;
using BeldYazilim.Dto.ArticleCategoryDtos;
using BeldYazilim.Dto.ArticleDtos;
using BeldYazilim.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace BeldYazilim.WebUI.ViewComponents._ArticleDetailMainViewComponents
{
    public class _ArticleDetailSideBarComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _ArticleDetailSideBarComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.blogid = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7298/api/AppUser/user-with-role-byArticleId/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var getUserWithRoleDto = JsonConvert.DeserializeObject<GetUserWithRoleByIdDtos>(jsonData);

                var topArticles = await GetTop3RatedArticlesAsync();
                var mainCategories = await GetArticleMainCategoriesAsync();
                var model = new ArticleDetailModel
                {
                    getTop3RatedArticles = topArticles,
                    getUserWithRoleByIdDtos = getUserWithRoleDto,
                    ResultMainCategoryDto=mainCategories
                };

                return View(model);
            }
            else
            {
                // Handle unsuccessful response
                return View();
            }
        }


        public async Task<List<GetTop3RatedArticles>> GetTop3RatedArticlesAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7298/api/Article/GetTopRatedArticles");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var topRatedArticles = JsonConvert.DeserializeObject<List<GetTop3RatedArticles>>(jsonData);
                return topRatedArticles;
            }
            else
            {
                // Handle unsuccessful response
                return new List<GetTop3RatedArticles>();
            }
        }


        public async Task<List<ResultMainCategoryDto>> GetArticleMainCategoriesAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7298/api/ArticleMainCategoryCategories");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var categories = JsonConvert.DeserializeObject<List<ResultMainCategoryDto>>(jsonData);
                return categories;
            }
            else
            {
                // Handle unsuccessful response
                return new List<ResultMainCategoryDto>();
            }
        }
    }
}
