using BeldYazilim.Dto.ArticleCategoryDtos;
using BeldYazilim.Dto.ArticleDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace BeldYazilim.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AdminArticleController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminArticleController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7298/api/Article");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultArticleDtos>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateArticle()
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7298/api/ArticleCategory/GetSubCategory");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultMainCategoryDto>>(jsonData);
            List<SelectListItem> subCategoryValues = (from x in values
                                                select new SelectListItem
                                                {
                                                    Text = x.name,
                                                    Value = x.subCategoryID.ToString(),
                                                    
                                                }).ToList();


            ViewBag.SubCategoryValues = subCategoryValues;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticle(CreateArticleDto createArticleDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createArticleDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync("https://localhost:7298/api/Article", stringContent);
            var responseMessage2 = await client.GetAsync("https://localhost:7298/api/ArticleCategory/GetSubCategory");
            var jsonData2 = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultMainCategoryDto>>(jsonData2);

            if (responseMessage.IsSuccessStatusCode)
            {
                return Content(values.ToString());
                //return RedirectToAction("AdminArticle", "Admin");
            }
            return View(createArticleDto);
        }






        public async Task<IActionResult> RemoveArticle(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7298/api/Article/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminArticle", "Admin");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateArticle(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var resposenMessage = await client.GetAsync($"https://localhost:7298/api/Article/{id}");
            if (resposenMessage.IsSuccessStatusCode)
            {
                var jsonData = await resposenMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateArticleDto>(jsonData); 
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateArticle(UpdateArticleDto updateArticleDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateArticleDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7298/api/Article/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminArticle", "Admin");
            }
            return View();
        }


    }
}
