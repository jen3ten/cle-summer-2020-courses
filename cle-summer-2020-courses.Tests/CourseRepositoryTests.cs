using cle_summer_2020_courses.Models;
using cle_summer_2020_courses.Repositories;
using NSubstitute.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace cle_summer_2020_courses.Tests
{
    public class CourseRepositoryTests
    {
        private IUniversityContext db;
        private CourseRepository underTest;

        public CourseRepositoryTests()
        {
            db = new TestUniversityContext();
            underTest = new CourseRepository(db);
        }

        [Fact]
        public void GetAll_Returns_List_of_Courses()
        {
            var result = underTest.GetAll().ToList();
            
            Assert.IsType<List<Course>>(result);
        }

        [Fact]
        public void GetAll_Returns_3_Courses()
        {
            var result = underTest.GetAll();

            Assert.Equal(3, result.Count());
        }

        [Fact]
        public void GetById_Returns_One_Course()
        {
            var result = underTest.GetById(1);

            Assert.IsType<Course>(result);
        }

        [Fact]
        public void GetById_Returns_First_Course()
        {
            var result = underTest.GetById(1);

            Assert.Equal("Test Course 1", result.Name);
        }

    }
}
