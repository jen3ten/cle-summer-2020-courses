using cle_summer_2020_courses.Models;
using cle_summer_2020_courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Controllers
{
    public class InstructorController : Controller
    {
        private IRepository<Instructor> instructorRepo;

        public InstructorController(IRepository<Instructor> instructorRepo)
        {
            this.instructorRepo = instructorRepo;
        }

        public ViewResult Index()
        {
            var model = instructorRepo.GetAll();

            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                instructorRepo.Create(instructor);
                return RedirectToAction("Index");
            }
            return View(instructor);
        }

    }
}
