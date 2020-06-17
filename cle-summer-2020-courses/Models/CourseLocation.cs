using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Models
{
    public class CourseLocation
    {
        public int Id { get; set; }
        public string Building { get; set; }
        public string RoomNumber { get; set; }

        public virtual Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
