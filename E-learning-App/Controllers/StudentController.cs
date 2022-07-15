using Microsoft.AspNetCore.Mvc;

namespace E_learning_App.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signin(string email, string password)
        {
            return View();
        }
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}
