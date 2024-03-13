using BeldYazilim.Dto.AppUserDtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BeldYazilim.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public RegisterController(IHttpClientFactory httpClientFactory)
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
		public async Task<IActionResult> Index(CreateAppUserDto createAppUserDto)
		{
            
            var client = _httpClientFactory.CreateClient();
			
			var jsonData = JsonConvert.SerializeObject(createAppUserDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7298/api/AppUser", stringContent);

			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index", "Confirm");
			}

            var content = await responseMessage.Content.ReadAsStringAsync();


            return Content(content);
		}



	}
}
