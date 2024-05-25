using coreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly AppDbContext _dbContext;

        public RegistrationController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User item)
        {
            _dbContext.Add(item);
            _dbContext.SaveChanges();
            return View();
        }
    }
}
