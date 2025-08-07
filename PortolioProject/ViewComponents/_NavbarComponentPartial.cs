using Microsoft.AspNetCore.Mvc;

namespace PortolioProject.ViewComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
