using InfoCut.Data;
using InfoCut.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace InfoCut.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        // Redirect old signup endpoint to Account/Signup
        [HttpGet]
        public IActionResult Signup()
        {
            return RedirectToAction("Signup", "Account");
        }

        [HttpPost]
        public IActionResult Signup(SignUp model)
        {
            return RedirectToAction("Signup", "Account");
        }

        // Redirect old signin endpoint to Account/Login
        [HttpGet]
        public IActionResult Signin()
        {
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public IActionResult Signin(LoginViewModel model)
        {
            return RedirectToAction("Login", "Account");
        }

        [Authorize]
        public IActionResult DailyUpdates()
        {
            return View();
        }

        [Authorize]
        public IActionResult Economy()
        {
            return View();
        }

        [Authorize]
        public IActionResult Top10()
        {
            return View();
        }

        [Authorize]
        public IActionResult Sports()
        {
            return View();
        }

        [Authorize]
        public IActionResult Tech()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}


