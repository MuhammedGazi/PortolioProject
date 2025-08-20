using Microsoft.AspNetCore.Mvc;
using PortolioProject.DAL.Context;

namespace PortolioProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        PortfolioContext context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount= context.ToDoLists.Where(x => x.Status == false).Count();
            var values=context.ToDoLists.Where(x=>x.Status==false).ToList();
            return View(values);
        }
    }
}
