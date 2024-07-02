using BeldYazilim.Domain.Entities;
using BeldYazilim.Dto.AppUserDtos;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BeldYazilim.WebUI.Controllers
{
    public class KalemController : Controller
    {


        [HttpGet]
        public IActionResult Index()
        {
            // Kullanıcının oturum açıp açmadığını kontrol edin
            
            if (User.Identity.IsAuthenticated)
            {
                // Kullanıcının kimlik bilgilerini alın
                var userId = User.Identity.GetUserId();
                var firstName = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.GivenName)?.Value;
                var surname = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Surname)?.Value;
                var district = User.Claims.FirstOrDefault(c => c.Type == "District")?.Value;

                // Kullanıcı profili verilerini bir modelle görünüme ileterek döndürün
                var userProfile = new CheckUserDto
                {
                    FirstName = firstName,
                    Surname = surname,
                    District = district
                };

                return Content(userId.ToString());
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
