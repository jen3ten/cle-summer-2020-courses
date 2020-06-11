using cle_summer_2020_courses.Controllers;
using cle_summer_2020_courses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace cle_summer_2020_courses.Tests
{
    public class CourseControllerTests
    {
        CourseController underTest;

        public CourseControllerTests()
        {
            underTest = new CourseController();
        }
        [Fact]
        public void Index_Returns_A_View()
        {
            //var underTest = new CourseController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_CourseModel_To_View()
        {

            var result = underTest.Index();

            Assert.IsType<Course>(result.Model);
        }

    }
}
