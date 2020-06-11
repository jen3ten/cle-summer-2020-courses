using cle_summer_2020_courses.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace cle_summer_2020_courses.Tests
{
    public class CourseTests
    {
        Course underTest;

        public CourseTests()
        {
            underTest = new Course("Course Name");
        }

        [Fact]
        public void CourseConstructor_Sets_Name_On_CourseModel()
        {
            var result = underTest.Name;

            Assert.Equal("Course Name", result);
        }
    }
}
