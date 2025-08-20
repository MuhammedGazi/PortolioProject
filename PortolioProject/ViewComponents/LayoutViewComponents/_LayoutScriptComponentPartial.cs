using Microsoft.AspNetCore.Mvc;

namespace PortolioProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
