using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
