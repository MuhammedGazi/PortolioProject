using Microsoft.AspNetCore.Mvc;

namespace PortolioProject.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
