using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSolution1
{
    public class Course
    {
        public string Title { get; set; }

        public int Fees { get; set; }

        public Instructor Teacher { get; set; } 

        public Adress address { get; set; }

        public string[] Prerequisites { get; set; }
    }
}
