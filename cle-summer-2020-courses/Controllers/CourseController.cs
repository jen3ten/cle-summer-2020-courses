using cle_summer_2020_courses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            Course model = new Course("Intro to MVC", 42, "All you need to know about MVC");
            return View(model);
        }

    }
}
