using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P01_StudentSystem.P01__StudentSystem.Models;

namespace P01_StudentSystem.P01__StudentSystem.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public Courses course { get; set; }
        public int CourseID { get; set; }
        public Students student { get; set; }
        public int StudentID { get; set; }

    }
}
