using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
