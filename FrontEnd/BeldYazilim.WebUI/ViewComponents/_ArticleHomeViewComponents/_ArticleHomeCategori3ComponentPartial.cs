using BeldYazilim.Dto.ArticleDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BeldYazilim.WebUI.ViewComponents._ArticleHomeViewComponents
{
	public class _ArticleHomeCategori3ComponentPartial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public _ArticleHomeCategori3ComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7298/api/Article/GetRandomArticle/9");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var last4Articles = JsonConvert.DeserializeObject<List<GetLastFiveArticlesByCategoryDto>>(jsonData);

				return View(last4Articles);
			}
			else
			{
				// Handle unsuccessful response
				return View();
			}
		}
	}
}
