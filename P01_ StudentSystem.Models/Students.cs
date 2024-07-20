using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01__StudentSystem.Models
{
    public class Students
    {
        public int StudentsId { get; set; }
        public DateTime? Birthday { get; set; }
        public string Name { get; set; }
        public string? PhoneNo { get; set; }
        public DateTime? RegisteredOn { get; set; }
    }
}
