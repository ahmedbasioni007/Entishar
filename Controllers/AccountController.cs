using Microsoft.AspNetCore.Mvc;
using Entishar.Data;
using Entishar.Models;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace Entishar.Controllers
{
    public class AccountController : Controller
    {
        private readonly EntisharContext _context;

        public AccountController(EntisharContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ViewBag.Error = "Username and Password are required";
                return View();
            }

            var user = _context.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password && u.IsActive);

            if (user != null)
            {
                HttpContext.Session.SetString("Username", user.Username);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid credentials or inactive user";
            return View();
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
