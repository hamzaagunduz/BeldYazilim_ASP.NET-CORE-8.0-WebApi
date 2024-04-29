using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebUI.ViewComponents._ArticleDetailMainViewComponents
{
    public class _ArticleDetailSideBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
