using BeldYazilim.Dto.AppUserDtos;
using BeldYazilim.Dto.ArticleDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BeldYazilim.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AdminUserController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public AdminUserController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7298/api/AppRole");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAppUserDtos>>(jsonData);


                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> RemoveUser(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7298/api/AppUser/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminUser", "Admin");

            }
            return View();
        }
    }
}
