using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebUI.ViewComponents._ArticleHomeViewComponents
{
	public class _ArticleHomeTopComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
