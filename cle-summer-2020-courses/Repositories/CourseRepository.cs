using cle_summer_2020_courses.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Repositories
{
    public class CourseRepository : UniversityRepository<Course>, IRepository<Course>
    {
        UniversityContext db;
        public CourseRepository(UniversityContext db) : base(db)
        {
            this.db = db;
        }

    }
}
