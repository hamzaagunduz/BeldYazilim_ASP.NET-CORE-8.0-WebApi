using BeldYazilim.Dto.ArticleDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BeldYazilim.WebUI.Controllers
{
	public class ArticleCategoryController : Controller
	{
		private readonly IHttpClientFactory _clientFactory;

		public ArticleCategoryController(IHttpClientFactory clientFactory)
		{
			_clientFactory = clientFactory;
		}

        public async Task<IActionResult> Index(int categoryId, int pageNumber, int pageSize)

        {


            var client = _clientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7298/api/Article/GetArticlesByCategoryPaged/{categoryId}/{pageNumber}/{pageSize}");

            if (response.IsSuccessStatusCode)
			{
				var jsonData = await response.Content.ReadAsStringAsync();
				var articles = JsonConvert.DeserializeObject<List<GetLastFiveArticlesByCategoryDto>>(jsonData); // Assuming Article is your DTO model

				// Önceki ve sonraki sayfalar için sayfa numaralarını hesapla
				//int nextPageNumber = pageNumber + 1;
				//int previousPageNumber = pageNumber - 1;


				return View(articles);
			}
			else
			{
				// Handle error
				return StatusCode((int)response.StatusCode);
			}
		}
	}

}
