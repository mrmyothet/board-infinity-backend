using Microsoft.AspNetCore.Mvc;

namespace Module2.AuthenticationApplication.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Policy()
        {
            return View();
        }
    }
}
