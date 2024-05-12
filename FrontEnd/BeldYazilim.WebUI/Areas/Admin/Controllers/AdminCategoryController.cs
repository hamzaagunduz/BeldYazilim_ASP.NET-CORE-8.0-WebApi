using BeldYazilim.Dto.ArticleCategoryDtos;
using BeldYazilim.Dto.ArticleDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BeldYazilim.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]

    [Area("Admin")]

    public class AdminCategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminCategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7298/api/ArticleMainCategoryCategories");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMainCategoryDto>>(jsonData);


                return View(values);
            }
            return View();
        }


        public async Task<IActionResult> CreateMainCategory(CreateMainCategoryDto createMainCategoryDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createMainCategoryDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync("https://localhost:7298/api/ArticleMainCategoryCategories", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("AdminCategory", "Admin");
            }
            return View();
        }


        public async Task<IActionResult> RemoveCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7298/api/ArticleMainCategoryCategories/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminCategory", "Admin");

            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var resposenMessage = await client.GetAsync($"https://localhost:7298/api/ArticleMainCategoryCategories/{id}");
            if (resposenMessage.IsSuccessStatusCode)
            {
                var jsonData = await resposenMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateMainCategoryDto>(jsonData);
                return View(values);
                //return Content(values.mainCategoryID.ToString());

            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateMainCategoryDto updateMainCategoryDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateMainCategoryDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7298/api/ArticleMainCategoryCategories/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminArticle", "Admin");
            }
            return View();

        }

    }
}
