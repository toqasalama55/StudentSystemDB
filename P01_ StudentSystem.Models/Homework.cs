using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P01_StudentSystem.P01__StudentSystem.Models;

namespace P01_StudentSystem.P01__StudentSystem.Models
{
    public class Homework
    {
        public int HomeWOrkID { get; set; }
        public string Contect { get; set; } 
        public enum ContentType
        {
            application ,
            Pdf ,
            Zip
        }
        public DateTime? SubmissionTime { get; set; }
        public List<Courses> Courses { get; set; }
        public int CourseID { get; set; }
        public List<Students> Students { get; set; }
        public int StudentID { get; set; }

    }
}
