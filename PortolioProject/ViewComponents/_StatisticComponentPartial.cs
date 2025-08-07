using Microsoft.AspNetCore.Mvc;

namespace PortolioProject.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
