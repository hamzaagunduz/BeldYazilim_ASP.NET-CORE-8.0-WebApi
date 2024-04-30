using BeldYazilim.Dto.AppUserDtos;
using BeldYazilim.Dto.ArticleDtos;
using BeldYazilim.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BeldYazilim.WebUI.ViewComponents._ArticleDetailMainViewComponents
{
    public class _ArticleDetailBotComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _ArticleDetailBotComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7298/api/Article/GetLast4Articles");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var last4Articles = JsonConvert.DeserializeObject<List<GetLast4ArticlesDto>>(jsonData);
                var model = new ArticleDetailModel
                {
                    getLast4ArticlesDto = last4Articles
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
