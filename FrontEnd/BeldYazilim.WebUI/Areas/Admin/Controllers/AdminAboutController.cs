using BeldYazilim.Dto.AboutDtos;
using BeldYazilim.Dto.ArticleDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BeldYazilim.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]

    [Area("Admin")]

    public class AdminAboutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _imageUploadDirectory = "C:\\Users\\Hamza\\Desktop\\BeldYazilim\\FrontEnd\\BeldYazilim.WebUI\\wwwroot\\images";
        public AdminAboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7298/api/Abouts/3");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetAboutDto>(jsonData);

                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(GetAboutDto updateArticleDto)
        {
            var client = _httpClientFactory.CreateClient();
            var multipartContent = new MultipartFormDataContent();

            multipartContent.Add(new StringContent(updateArticleDto.aboutID.ToString()), "aboutID");
            multipartContent.Add(new StringContent(updateArticleDto.title), "title");
            multipartContent.Add(new StringContent(updateArticleDto.content), "content");
            multipartContent.Add(new StringContent(updateArticleDto.title2), "title2");
            multipartContent.Add(new StringContent(updateArticleDto.content2), "content2");



            multipartContent.Add(new StreamContent(updateArticleDto.photo.OpenReadStream()), "photo", updateArticleDto.photo.FileName);
            multipartContent.Add(new StreamContent(updateArticleDto.photo2.OpenReadStream()), "photo2", updateArticleDto.photo2.FileName);

            var responseMessage = await client.PutAsync("https://localhost:7298/api/Abouts", multipartContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminArticle", "Admin");
            }
            return View();
        }

    }
}

