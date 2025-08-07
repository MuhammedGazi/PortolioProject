using Microsoft.AspNetCore.Mvc;

namespace PortolioProject.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
