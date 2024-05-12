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

    public class AdminTagController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminTagController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7298/api/Tag");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetAllTagDto>>(jsonData);


                return View(values);
            }
            return View();
        }


        public async Task<IActionResult> CreateTag(CreateTagDto createTagDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createTagDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync("https://localhost:7298/api/Tag/CreateNewArticleTag", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("AdminTag", "Admin");
            }
            return View();
        }


        public async Task<IActionResult> RemoveTag(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7298/api/Tag/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminTag", "Admin");

            }
            return Content(responseMessage.Content.ToString());
        }
        [HttpGet]
        public async Task<IActionResult> UpdateTag(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var resposenMessage = await client.GetAsync($"https://localhost:7298/api/Tag/GetTagByTagId/{id}");
            if (resposenMessage.IsSuccessStatusCode)
            {
                var jsonData = await resposenMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateTagDto>(jsonData);
                return View(values);
                //return Content(values.mainCategoryID.ToString());

            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTag(UpdateTagDto updateTagDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateTagDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7298/api/Tag/UpdateTag", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminTag", "Admin");
            }
            return View();

        }
    }
}
