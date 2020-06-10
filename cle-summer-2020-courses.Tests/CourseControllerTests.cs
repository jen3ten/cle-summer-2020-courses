using System;
using Xunit;

namespace cle_summer_2020_courses.Tests
{
    public class CourseControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
