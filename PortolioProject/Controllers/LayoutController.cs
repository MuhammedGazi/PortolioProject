using Microsoft.AspNetCore.Mvc;

namespace PortolioProject.Controllers
{
    public class LayoutController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
