using Microsoft.AspNetCore.Mvc;

namespace E_learning_App.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InstructorDashboard()
        {
            return View();
        }
    }
}
