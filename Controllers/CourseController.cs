using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult coursePage()
        {
            return View();
        }
    }
}
