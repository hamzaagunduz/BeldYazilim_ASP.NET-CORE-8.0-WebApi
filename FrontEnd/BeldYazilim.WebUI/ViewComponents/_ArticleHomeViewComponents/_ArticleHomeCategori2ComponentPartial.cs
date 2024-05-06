using BeldYazilim.Dto.ArticleDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BeldYazilim.WebUI.ViewComponents._ArticleHomeViewComponents
{
	public class _ArticleHomeCategori2ComponentPartial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public _ArticleHomeCategori2ComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7298/api/Article/GetLastFiveArticlesByCategory/4");

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
