using coreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace coreWebApplication.Controllers
{
    public class CustomerController : Controller
    {
        public static readonly List<Customer> lstCustomer = new List<Customer>() 
        { 
            new Customer() { Id = 101, Name = "NuStar Technologies Pte Ltd", Amount = 3000 }, 
            new Customer() { Id = 102, Name = "WEFIC - Oilfield Engineering Services", Amount = 1500 }
        };

        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System";
            ViewBag.CustomerCount = lstCustomer.Count();
            ViewBag.CustomerList = lstCustomer;

            return View();
        }

        public IActionResult Details() { return View(); }

        // Attribute Routing
        //[Route("~/")]
        [Route("/sample/message")]
        public IActionResult Message() { return View(); }

    }
}
