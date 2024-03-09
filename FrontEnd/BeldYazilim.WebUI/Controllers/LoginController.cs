using BeldYazilim.Dto.AppUserDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BeldYazilim.WebUI.Controllers
{
	public class LoginController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public LoginController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		[HttpGet]
		public IActionResult Index()
		{
			// Eylemin içeriği
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(LoginAppUserDto loginAppUserDto)
		{
			var client = _httpClientFactory.CreateClient();
		



			return View();
		}
	}
}
