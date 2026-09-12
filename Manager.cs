using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rethabile_Ledidi_601910
{
     public class Manager
    {
        public delegate void ResultProcessedHandler(Student s);

        public class StudentManager
        {
            public event ResultProcessedHandler OnResultProcessed;

            public List<Student> students = new List<Student>();

            public void AddStudent(Student s)
            {
                students.Add(s);
                if (OnResultProcessed != null)
                {
                    OnResultProcessed(s);
                }
            }

        }