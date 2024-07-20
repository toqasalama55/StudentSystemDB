using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01__StudentSystem.Models
{
    public class Courses
    {
        public int CoursesId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime  StartDate { get; set; }
        public DateTime  EndDate { get; set; }
        public decimal  Price { get; set; }
    }
}
