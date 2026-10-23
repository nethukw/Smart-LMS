using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLMS
{
    public class Submission
    {
        public int StudentId { get; set; }
        public int AssignmentId { get; set; }
        public string FileName { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string Comments { get; set; }
    }
}
