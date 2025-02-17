using Microsoft.AspNetCore.Mvc;

namespace newpractices.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
