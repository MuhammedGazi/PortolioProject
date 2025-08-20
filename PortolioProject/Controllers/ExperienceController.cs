using Microsoft.AspNetCore.Mvc;
using PortolioProject.DAL.Context;
using PortolioProject.DAL.Entities;

namespace PortolioProject.Controllers
{
    public class ExperienceController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult ExperienceList()
        {
            var values=context.Expereinces.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Expereince expereince)
        {
            context.Expereinces.Add(expereince);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value=context.Expereinces.Find(id);
            context.Expereinces.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Expereinces.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Expereince expereince)
        {
            context.Expereinces.Update(expereince);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
