using Microsoft.AspNetCore.Mvc;

namespace ISFinalProjectPlantDetective.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
