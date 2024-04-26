using BeldYazilim.Dto.ArticleCategoryDtos;
using BeldYazilim.Dto.ArticleDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BeldYazilim.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AdminArticleController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _imageUploadDirectory = "C:\\Users\\Hamza\\Desktop\\BeldYazilim\\FrontEnd\\BeldYazilim.WebUI\\wwwroot\\images";

        public AdminArticleController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7298/api/Article/ArticleListWithAuthorsAndCategory");
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
            var responseMessage = await client.GetAsync("https://localhost:7298/api/ArticleMainCategoryCategories");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultMainCategoryDto>>(jsonData);
            List<SelectListItem> categoryValues = (from x in values
                                                   select new SelectListItem
                                                   {
                                                       Text = x.name,
                                                       Value = x.articleMainCategoryID.ToString()
                                                   }).ToList();
            ViewBag.CategoryValues = categoryValues;


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticle(CreateArticleDto createArticleDto)
        {
            var client = _httpClientFactory.CreateClient();
            using var formData = new MultipartFormDataContent();

            // Diğer alanları ekleyin
            formData.Add(new StringContent(createArticleDto.Title), "Title");
            formData.Add(new StringContent(createArticleDto.Content), "Content");
            formData.Add(new StringContent(createArticleDto.MainCategoryId.ToString()), "MainCategoryID");

            // Fotoğrafı ekleyin
            formData.Add(new StreamContent(createArticleDto.Photo.OpenReadStream()), "Photo", createArticleDto.Photo.FileName);

            var responseMessage = await client.PostAsync("https://localhost:7298/api/Article", formData);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminArticle", "Admin");
            }

            // Hata durumunda, geri dönüş yapın veya uygun bir hata mesajı gösterin
            return Content(responseMessage.Content.ToString());
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
            var multipartContent = new MultipartFormDataContent();

            multipartContent.Add(new StringContent(updateArticleDto.articleID.ToString()), "articleID");
            multipartContent.Add(new StringContent(updateArticleDto.title), "title");
            multipartContent.Add(new StringContent(updateArticleDto.content), "content");
            multipartContent.Add(new StringContent(updateArticleDto.mainCategoryId.ToString()), "mainCategoryId");
            multipartContent.Add(new StringContent(updateArticleDto.creationTime.ToString()), "creationTime");
            multipartContent.Add(new StringContent(updateArticleDto.clickCount.ToString()), "clickCount");
            multipartContent.Add(new StringContent(updateArticleDto.rating.ToString()), "rating");


            multipartContent.Add(new StreamContent(updateArticleDto.Photo.OpenReadStream()), "Photo", updateArticleDto.Photo.FileName);

            var responseMessage = await client.PutAsync("https://localhost:7298/api/Article/", multipartContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminArticle", "Admin");
            }
            return View();
        }

        [HttpPost("Admin/UploadCKEditorImage")]
        public JsonResult UploadCKEditorImage()
        {
            var files = Request.Form.Files;
            if (files.Count == 0)
            {
                var rError = new
                {
                    uploaded = false,
                    url = string.Empty
                };
                return Json(rError);
            }

            var formFile = files[0];
            var upFileName = formFile.FileName;

            var fileName = Path.GetFileNameWithoutExtension(upFileName) +
                DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(upFileName);

            var saveDir = @".\wwwroot\upload\";
            var savePath = saveDir + fileName;
            var previewPath = "/upload/" + fileName;

            bool result = true;
            try
            {
                if (!Directory.Exists(saveDir))
                {
                    Directory.CreateDirectory(saveDir);
                }
                using (FileStream fs = System.IO.File.Create(savePath))
                {
                    formFile.CopyTo(fs);
                    fs.Flush();
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            var rUpload = new
            {
                uploaded = result,
                url = result ? previewPath : string.Empty
            };
            return Json(rUpload);
        }


    }
}
