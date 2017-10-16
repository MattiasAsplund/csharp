using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLib
{
    public class SchoolSystem
    {
        private List<Class> classes = new List<Class>();
        public int ClassCount {
            get
            {
                return classes.Count;
            }
        }
        public int StudentCount {
            get
            {
                return classes.Sum(c => c.NumberOfStudents);
            }
        }

        public void AddClass(string className, int numberOfStudents)
        {
            var Class = classes.SingleOrDefault(c => c.Name == className);
            if (Class != null)
            {
                Class.NumberOfStudents += numberOfStudents;
            }
            else
                classes.Add(new Class { Name = className, NumberOfStudents = numberOfStudents });
        }
    }
}
