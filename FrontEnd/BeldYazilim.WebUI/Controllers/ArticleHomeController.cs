using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebUI.Controllers
{
    public class ArticleHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
