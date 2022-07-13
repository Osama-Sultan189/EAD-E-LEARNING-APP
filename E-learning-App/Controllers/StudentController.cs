using Microsoft.AspNetCore.Mvc;

namespace E_learning_App.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Signin()
        {
            return View();
        }
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}
