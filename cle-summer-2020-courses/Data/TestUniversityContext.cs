using cle_summer_2020_courses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses
{
    public class TestUniversityContext : DbContext, IUniversityContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseLocation> CourseLocations { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=TestUniversity_summer2020;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course()
                {
                    Id = 1,
                    Name = "Test Course 1",
                    Description = "Test Course Description 1",
                    InstructorId = 1
                },

                new Course()
                {
                    Id = 2,
                    Name = "Test Course 1",
                    Description = "Test Course Description 1",
                    InstructorId = 2
                },

                new Course()
                {
                    Id = 3,
                    Name = "Test Course 1",
                    Description = "Test Course Description 1",
                    InstructorId = 2
                });

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    Id = 1,
                    Name = "Test Instructor 1"
                },

                new Instructor()
                {
                    Id = 2,
                    Name = "Test Instructor 2"
                });

            modelBuilder.Entity<CourseLocation>().HasData(
                new CourseLocation()
                {
                    Id = 1,
                    Building = "Test Building 1",
                    RoomNumber = "Test Room Number 1",
                    CourseId = 1
                },

                new CourseLocation()
                {
                    Id = 2,
                    Building = "Test Building 2",
                    RoomNumber = "Test Room Number 2",
                    CourseId = 2
                },

                new CourseLocation()
                {
                    Id = 3,
                    Building = "Test Building 3",
                    RoomNumber = "Test Room Number 3",
                    CourseId = 3
                });

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    Name = "Test Student 1"
                },

                new Student()
                {
                    Id = 2,
                    Name = "Test Student 2"
                },

                new Student()
                {
                    Id = 3,
                    Name = "Test Student 3"
                });

            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse()
                {
                    Id = 1,
                    CourseId = 1,
                    StudentId = 1
                },

                new StudentCourse()
                {
                    Id = 2,
                    CourseId = 1,
                    StudentId = 2
                },

                new StudentCourse()
                {
                    Id = 3,
                    CourseId = 2,
                    StudentId = 2
                },

                new StudentCourse()
                {
                    Id = 4,
                    CourseId = 2,
                    StudentId = 3
                },

                new StudentCourse()
                {
                    Id = 5,
                    CourseId = 3,
                    StudentId = 1
                },

                new StudentCourse()
                {
                    Id = 6,
                    CourseId = 3,
                    StudentId = 3
                });



            base.OnModelCreating(modelBuilder);

        }
    }
}
