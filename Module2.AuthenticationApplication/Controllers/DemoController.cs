using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Module2.AuthenticationApplication.Controllers
{
    public class DemoController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Details()
        {
            return View();
        }

        [Authorize]
        public IActionResult Policy()
        {
            return View();
        }
    }
}
