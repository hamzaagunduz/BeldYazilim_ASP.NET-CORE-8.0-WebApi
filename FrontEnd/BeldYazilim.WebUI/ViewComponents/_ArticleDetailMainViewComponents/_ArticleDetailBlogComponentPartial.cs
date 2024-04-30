using BeldYazilim.Dto.ArticleDtos;
using BeldYazilim.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BeldYazilim.WebUI.ViewComponents._ArticleDetailMainViewComponents
{
    public class _ArticleDetailBlogComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _ArticleDetailBlogComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.blogid = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7298/api/Article/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var getAllArticleDto = JsonConvert.DeserializeObject<GetAllArticleDto>(jsonData);

                var model = new ArticleDetailModel
                {
                    getAllArticleDto = getAllArticleDto
                };

                return View(model);
            }
            else
            {
                // Handle unsuccessful response
                return View();
            }

        }
    }

}
