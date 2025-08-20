using Microsoft.AspNetCore.Mvc;
using PortolioProject.DAL.Context;

namespace PortolioProject.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        PortfolioContext portfolioContext=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=portfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
