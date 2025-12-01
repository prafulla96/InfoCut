using InfoCut.Data;
using InfoCut.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InfoCut.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
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

        public IActionResult DailyUpdates()
        {
            return View();
        }

        public IActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signin(string Username, string password)
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(password))
            {
                ModelState.AddModelError("", "Username and password are required.");
                return View();
            }

            var user = await _context.SignUps
                .FirstOrDefaultAsync(u => u.Username == Username && u.password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("IsLoggedIn", "true");
                TempData["SuccessMessage"] = "Sign in successful!";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password.");
                return View();
            }
        }
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signup(SignUp model)
        {
            if (ModelState.IsValid)
            {
                _context.SignUps.Add(model);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Submission successful!";
                return RedirectToAction("Signin");
            }
            return View(model);
        }
        

        public IActionResult Economy()
        {
            return View();
        }

        public IActionResult Top10()
        {
            return View();
        }
        public IActionResult Sports()
        {
            return View();
        }

        public IActionResult Tech()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Terms()
        {
            return View();
        }

        public IActionResult Profile()
        {
            if (HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                return RedirectToAction("Signin");
            }

            // For demo: get the first signed-up user (replace with actual user lookup in production)
            var user = _context.SignUps.FirstOrDefault();
            if (user == null)
            {
                TempData["ErrorMessage"] = "User not found.";
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}
