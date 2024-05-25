using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult WeeklyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPost(string userName, string password)
        {
            ViewBag.UserName = userName;
            ViewBag.Password = password;
            return View();
        }
    }
}
