using Microsoft.AspNetCore.Mvc;

namespace ISFinalProjectPlantDetective.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
