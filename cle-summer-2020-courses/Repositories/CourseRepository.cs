﻿using cle_summer_2020_courses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Repositories
{
    public class CourseRepository : Repository<Course>, IRepository<Course>
    {
        //private UniversityContext db;

        public CourseRepository(UniversityContext db) : base(db)
        {
            //this.db = db;
        }

        //public void Create(Course course)
        //{
        //    db.Courses.Add(course);
        //    db.SaveChanges();
        //}

        //public IEnumerable<Course> GetAll()
        //{
        //    return db.Courses;
        //}
        //public Course GetById(int id)
        //{
        //    return db.Courses.Single(c => c.Id == id);
        //}
    }
}
