using Microsoft.AspNetCore.Mvc;

namespace PortolioProject.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
