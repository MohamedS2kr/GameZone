using Microsoft.AspNetCore.Mvc;

namespace GameZone.Controllers
{
    public class GamesController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
