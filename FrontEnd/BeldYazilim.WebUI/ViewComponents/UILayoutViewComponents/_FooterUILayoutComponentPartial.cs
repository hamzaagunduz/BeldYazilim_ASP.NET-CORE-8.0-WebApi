using BeldYazilim.Dto.ArticleDtos;
using BeldYazilim.Dto.FooterDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BeldYazilim.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _FooterUILayoutComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _FooterUILayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7298/api/Footer");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var topRatedArticles = JsonConvert.DeserializeObject<List<GetFooterAboutDto>>(jsonData);
                return View(topRatedArticles);
            }
            else
                return View();
        }
    }
}
