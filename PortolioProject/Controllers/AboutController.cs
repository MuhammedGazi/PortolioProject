using Microsoft.AspNetCore.Mvc;
using PortolioProject.DAL.Context;
using PortolioProject.DAL.Entities;

namespace PortolioProject.Controllers
{
    public class AboutController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult Index()
        {
            var values=context.Abouts.ToList();
            return View(values);
        }


        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAbout(int id)
        {
            var deletedvalue=context.Abouts.Find(id);
            context.Abouts.Remove(deletedvalue);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditAbout(int id)
        {
            var value=context.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditAbout(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
