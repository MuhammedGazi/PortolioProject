using Microsoft.AspNetCore.Mvc;

namespace PortolioProject.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
