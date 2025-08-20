using Microsoft.AspNetCore.Mvc;

namespace PortolioProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
