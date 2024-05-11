using BeldYazilim.Dto.AppUserDtos;
using BeldYazilim.Dto.ArticleDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BeldYazilim.WebUI.ViewComponents.AboutViewComponents
{
	public class _AboutTeamComponentPartial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public _AboutTeamComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7298/api/AppUser/GetUsersWithAdminRoleQuery\r\n");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var last4Articles = JsonConvert.DeserializeObject<List<AboutTeamDto>>(jsonData);

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
