using BeldYazilim.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebUI.Controllers
{
    [Authorize]

    public class KalemController : Controller
    {
        //private readonly UserManager<AppUser> _userManager;
        //public KalemController(UserManager<AppUser> userManager)
        //{
        //    _userManager = userManager;
        //}

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
