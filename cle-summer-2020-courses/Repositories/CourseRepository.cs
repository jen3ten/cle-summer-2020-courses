using cle_summer_2020_courses.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Repositories
{
    public class CourseRepository : Repository<Course>, IRepository<Course>, ISelectList
    {
        UniversityContext db;
        public CourseRepository(UniversityContext db) : base(db)
        {
            this.db = db;
        }

        public List<SelectListItem> PopulateInstructorList()
        {
            var instructorQuery = from i in db.Instructors
                                  orderby i.Name
                                  select i;

            return instructorQuery.ToList();
        }

    }
}
