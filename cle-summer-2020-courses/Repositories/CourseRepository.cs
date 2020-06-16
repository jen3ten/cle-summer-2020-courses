using cle_summer_2020_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        public List<Course> coursesList;

        public CourseRepository()
        {
            coursesList = new List<Course>()
            {
                new Course("Machine Learning", 1, "Machine learning for humans"),
                new Course("C# for Smarties", 2, "It's all you need to learn it all"),
                new Course("HTML, CSS, JS, oh my!", 3, "OMG, the front end will become your BFF")
            };

        }

        public IEnumerable<Course> GetAll()
        {
            return coursesList;
        }
        public Course GetById(int id)
        {
            return coursesList.Single(c => c.Id == id);
        }
    }
}
