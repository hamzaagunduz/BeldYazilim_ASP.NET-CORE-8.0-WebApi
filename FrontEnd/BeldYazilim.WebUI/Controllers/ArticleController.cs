using BeldYazilim.Dto.AppUserDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BeldYazilim.WebUI.Controllers
{
    [Authorize]
    public class ArticleController : Controller
    {
        [HttpGet]
        //public IActionResult Index()
        //{
        //    // Kullanıcı bilgilerine erişmek için HttpContext.User kullanılır
        //    var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        //    var username = HttpContext.User.Identity.Name;

        //    // Kullanıcı bilgileri burada kullanılabilir
        //    var userData = new CheckUserDto
        //    {
        //        UserId = userId,
        //        UserName = username,
        //        // Diğer kullanıcı bilgilerini buraya ekleyin
        //    };

        //    // Modeli kullanarak ilgili görünümü döndürün
        //    return View(userData);
        //}

        [HttpGet]
        public IActionResult Index()
        {
            // Kullanıcının oturum açıp açmadığını kontrol edin
            if (User.Identity.IsAuthenticated)
            {
                // Kullanıcının kimlik bilgilerini alın
                var userName = User.Identity.Name;
                var firstName = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.GivenName)?.Value;
                var surname = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Surname)?.Value;
                var district = User.Claims.FirstOrDefault(c => c.Type == "District")?.Value;

                // Kullanıcı profili verilerini bir modelle görünüme ileterek döndürün
                var userProfile = new CheckUserDto
                {
                    UserName = userName,
                    FirstName = firstName,
                    Surname = surname,
                    District = district
                };

                return View(userProfile);
            }
            else
            {
                // Kullanıcı oturum açmamışsa uygun bir işlem yapın
                // Örneğin, bir hata sayfasına yönlendirin veya oturum açma sayfasına geri yönlendirin
                return RedirectToAction("Login", "Account");
            }
        }
    }
}
