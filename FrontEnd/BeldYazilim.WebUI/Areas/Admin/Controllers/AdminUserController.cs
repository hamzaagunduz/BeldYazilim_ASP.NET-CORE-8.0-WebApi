using BeldYazilim.Dto.AppUserDtos;
using BeldYazilim.Dto.ArticleCategoryDtos;
using BeldYazilim.Dto.ArticleDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Text;

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

        [HttpGet]
        public async Task<IActionResult> UpdateUser(int id)
        {
            var roles = await GetRoles();
            ViewBag.RoleValues = roles; // ViewBag'e rolleri atıyoruz

            var client = _httpClientFactory.CreateClient();
            var resposenMessage = await client.GetAsync($"https://localhost:7298/api/AppUser/{id}");
            if (resposenMessage.IsSuccessStatusCode)
            {
                var jsonData = await resposenMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateAppUserDtos>(jsonData);

                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UpdateAppUserDtos updateAppUserDtos)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateAppUserDtos);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7298/api/AppUser", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminUser", "Admin");
            }
            return Content(responseMessage.StatusCode.ToString());
        }

        public async Task<List<SelectListItem>> GetRoles()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7298/api/AppRole/GetAllRole");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var roles = JsonConvert.DeserializeObject<List<Role>>(jsonData);

                List<SelectListItem> roleList = (from x in roles
                                                       select new SelectListItem
                                                       {
                                                           Text = x.roleName,
                                                           Value = x.roleId.ToString()
                                                       }).ToList();

                return roleList;
            }
            else
            {
                // API'den roller alınamadı
                return new List<SelectListItem>();
            }
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
