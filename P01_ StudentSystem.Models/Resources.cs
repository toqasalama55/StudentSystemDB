using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01__StudentSystem.Models
{
    public  class Resources
    {
        public int ResourcesID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public enum ResourceType
        {
            Video ,
            Presentation ,
            Document ,
            Other
        }
        
        public Courses course { get; set; }
        public int CourseID { get; set; }
    }
}
