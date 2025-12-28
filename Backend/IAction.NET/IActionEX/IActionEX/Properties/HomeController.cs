using Microsoft.AspNetCore.Mvc;

namespace IActionEX.Properties
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
