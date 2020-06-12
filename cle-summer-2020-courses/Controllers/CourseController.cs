using cle_summer_2020_courses.Models;
using cle_summer_2020_courses.Repositories;
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
            CourseRepository courseRepo = new CourseRepository();

            var model = courseRepo.GetAll();

            return View(model);

        }
    }
}
