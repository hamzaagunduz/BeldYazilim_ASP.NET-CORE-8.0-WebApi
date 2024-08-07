﻿using BeldYazilim.Dto.ArticleCategoryDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BeldYazilim.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _NavbarUILayoutComponentPartial : ViewComponent
    {
		private readonly IHttpClientFactory _httpClientFactory;
		public _NavbarUILayoutComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7298/api/ArticleMainCategoryCategories");

			if (response.IsSuccessStatusCode)
			{
				var jsonData = await response.Content.ReadAsStringAsync();
				var categories = JsonConvert.DeserializeObject<List<ResultMainCategoryDto>>(jsonData);
				return View(categories);
			}
			else
			{
				// Handle unsuccessful response
				return View();
			}
		}
	}
}
