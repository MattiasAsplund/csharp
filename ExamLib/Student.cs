using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib
{
    public class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
