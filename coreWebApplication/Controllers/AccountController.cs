using coreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult WeaklyTypedLogin()
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

        public IActionResult StronglyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginSuccess(UserAccount item)
        {
            ViewBag.UserName = item.UserName;
            ViewBag.Password = item.Password;
            return View();
        }

        public IActionResult UserDetail()
        {
            UserAccount user = new UserAccount() { UserName = "User 1", Password = "User1_Password" };
            return View(user);
        }

        public IActionResult UserList()
        {
            var lst = new List<UserAccount>();

            lst.Add(new UserAccount() { UserName = "User1", Password = "User1_Password" });
            lst.Add(new UserAccount() { UserName = "User2", Password = "User2_Password" });
            lst.Add(new UserAccount() { UserName = "User3", Password = "User3_Password" });

            return View(lst);
        }

        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostAccount(Account item)
        {
            if (ModelState.IsValid)
            {
                return View("CreateAccountSuccess");
            }

            return RedirectToAction("CreateAccount");
        }
    }
}
