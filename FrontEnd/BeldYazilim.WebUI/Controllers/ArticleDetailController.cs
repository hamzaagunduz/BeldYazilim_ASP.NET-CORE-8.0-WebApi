using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebUI.Controllers
{
    public class ArticleDetailController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {

            ViewBag.blogid = id;
            return View();
        }

    }
}
