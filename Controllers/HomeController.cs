using Microsoft.AspNetCore.Mvc;
using MobilePhoneRegistrationMVC.Data;
using MobilePhoneRegistrationMVC.Models;

namespace MobilePhoneRegistrationMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var phones = _context.PhoneRegistrations.ToList();
            return View(phones);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PhoneRegistration phone)
        {
            _context.PhoneRegistrations.Add(phone);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
