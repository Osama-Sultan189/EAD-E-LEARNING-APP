﻿using Microsoft.AspNetCore.Mvc;

namespace E_learning_App.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
