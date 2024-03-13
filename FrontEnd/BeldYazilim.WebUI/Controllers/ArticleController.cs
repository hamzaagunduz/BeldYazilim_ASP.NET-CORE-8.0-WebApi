using BeldYazilim.Dto.AppUserDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BeldYazilim.WebUI.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ArticleController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Kullanıcı bilgilerine erişmek için HttpContext.User kullanılır
            var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var username = HttpContext.User.Identity.Name;

            // Kullanıcı bilgileri burada kullanılabilir
            var userData = new CheckUserDto
            {
                UserId = userId,
                UserName = username,
                // Diğer kullanıcı bilgilerini buraya ekleyin
            };

            // Modeli kullanarak ilgili görünümü döndürün
            return View(userData);
        }
    }
}
