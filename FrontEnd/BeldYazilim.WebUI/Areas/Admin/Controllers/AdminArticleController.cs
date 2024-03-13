using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AdminArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
