using Microsoft.AspNetCore.Mvc;

namespace PortolioProject.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
