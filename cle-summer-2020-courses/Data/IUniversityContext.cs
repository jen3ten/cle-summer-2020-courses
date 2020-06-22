using cle_summer_2020_courses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses
{
    public interface IUniversityContext 
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseLocation> CourseLocations { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

    }
}
