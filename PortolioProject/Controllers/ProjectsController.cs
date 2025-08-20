using Microsoft.AspNetCore.Mvc;
using PortolioProject.DAL.Context;
using PortolioProject.DAL.Entities;

namespace PortolioProject.Controllers
{
    public class ProjectsController : Controller
    {
        PortfolioContext context= new PortfolioContext();
        public IActionResult Index()
        {
            var values=context.Portfolios.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProject(Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProject(int id)
        {
            var deletevalues=context.Portfolios.Find(id);
            context.Portfolios.Remove(deletevalues);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditProject(int id)
        {
            var values= context.Portfolios.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditProject(Portfolio portfolio)
        {
            context.Portfolios.Update(portfolio);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
