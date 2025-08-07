using Microsoft.AspNetCore.Mvc;

namespace PortolioProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
