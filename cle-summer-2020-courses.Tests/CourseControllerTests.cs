using cle_summer_2020_courses.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace cle_summer_2020_courses.Tests
{
    public class CourseControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new CourseController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
