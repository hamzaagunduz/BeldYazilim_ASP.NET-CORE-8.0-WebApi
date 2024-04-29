using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebUI.ViewComponents._ArticleDetailMainViewComponents
{
    public class _ArticleDetailCommentComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
