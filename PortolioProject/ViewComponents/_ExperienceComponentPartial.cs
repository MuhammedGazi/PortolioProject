using Microsoft.AspNetCore.Mvc;
using PortolioProject.DAL.Context;

namespace PortolioProject.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=portfolioContext.Expereinces.ToList();
            return View(values);
        }
    }
}
