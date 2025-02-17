using Microsoft.AspNetCore.Mvc;

namespace Demo_1.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
