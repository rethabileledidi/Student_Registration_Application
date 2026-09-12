using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rethabile_Ledidi_601910
{
    public enum CourseType
    {
        IT,
        Business,
        Engineering,
        Education
    }

    public class Student
    {
        public int StudentID;
        public string Name;
        public CourseType Course;
        public double Mark;

        public string GetResult()
        {
            if (Mark >= 50)
                return "Pass";
            else
                return "Fail";
        }
    }
}
