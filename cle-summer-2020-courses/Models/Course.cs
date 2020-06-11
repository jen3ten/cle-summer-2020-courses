using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Models
{
    public class Course
    {
        public string Name { get; set; }

        public Course()
        {
        }

        public Course(string name)
        {
            Name = name;
        }
    }
}
