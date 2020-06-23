using cle_summer_2020_courses.Controllers;
using cle_summer_2020_courses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using NSubstitute;
using cle_summer_2020_courses.Repositories;
using System.Collections;
using System.Collections.Generic;

namespace cle_summer_2020_courses.Tests
{
    public class CourseControllerTests
    {
        CourseController underTest;
        IRepository<Course> courseRepo;

        public CourseControllerTests()
        {
            courseRepo = Substitute.For<IRepository<Course>>();
            underTest = new CourseController(courseRepo);
        }
        [Fact]
        public void Index_Returns_A_ViewResult()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Courses_To_View()
        {
            var expectedCourses = new List<Course>();
            courseRepo.GetAll().Returns(expectedCourses);
            
            var result = underTest.Index();

            Assert.Equal(expectedCourses, result.Model);
        }

        [Fact]
        public void Details_Returns_a_ViewResult()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Course_To_View()
        {
            var expectedCourse = new Course();
            courseRepo.GetById(1).Returns(expectedCourse);
            
            var result = underTest.Details(1);
            
            Assert.Equal(expectedCourse, result.Model);
        } 

        [Fact]
        public void Create_Returns_a_ViewResult()
        {
            var result = underTest.Create();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Create_Post_Action_Returns_an_ActionResult()
        {
            var result = underTest.Create(new Course());

            Assert.IsAssignableFrom<ActionResult>(result);
        }

        [Fact]
        public void Create_Will_Not_Execute_If_Invalid_Model_State()
        {
            underTest.ModelState.AddModelError("Name", "Name is required");
            var newCourse = new Course();

            underTest.Create(newCourse);

            courseRepo.DidNotReceive().Create(newCourse);
        }

        [Fact]
        public void Create_Will_Execute_if_Valid_Model_State()
        {
            var newCourse = new Course();

            underTest.Create(newCourse);

            courseRepo.Received().Create(newCourse);
        }

    }
}
