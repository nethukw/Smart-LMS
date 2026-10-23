using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLMS
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public string Schedule { get; set; }
        public int Capacity { get; set; }
    }
}
