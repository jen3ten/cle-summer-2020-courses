using cle_summer_2020_courses.Models;
using cle_summer_2020_courses.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace cle_summer_2020_courses.Tests
{
    public class CourseRepositoryTests
    {
        private UniversityContext db;
        private CourseRepository underTest;

        public CourseRepositoryTests()
        {
            db = new UniversityContext();
            underTest = new CourseRepository(db);
        }

        [Fact]
        public void GetAll_Returns_List_of_Courses()
        {
            var result = underTest.GetAll();
            
            Assert.IsType<List<Course>>(result);
        }
    }
}
