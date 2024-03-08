using BeldYazilim.Dto.AppUserDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BeldYazilim.WebUI.ViewComponents.RegisterViewComponents
{
    public class _RegisterComponentPartial : ViewComponent
    {
        
      
        public IViewComponentResult Invoke()
        {
            return View();
        }

      
    }
}
