using Microsoft.AspNetCore.Mvc;

namespace PortolioProject.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
