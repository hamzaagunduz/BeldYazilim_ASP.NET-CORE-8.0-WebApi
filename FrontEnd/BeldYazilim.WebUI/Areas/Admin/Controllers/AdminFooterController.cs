using BeldYazilim.Dto.ArticleDtos;
using BeldYazilim.Dto.FooterDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BeldYazilim.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminFooterController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminFooterController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7298/api/Footer/1");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateFooterAboutDto>(jsonData);


                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UpdateFooterAboutDto updateFooterDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateFooterDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7298/api/Footer", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminTag", "Admin");
            }
            return View();

        }
    }
}
