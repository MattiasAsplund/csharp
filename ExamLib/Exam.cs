using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib
{
    public class Exam
    {
        private string courseName;
        private Dictionary<Student, string> studentGradeDictionary = 
            new Dictionary<Student, string>();
        public Exam(string courseName)
        {
            this.courseName = courseName;
        }

        public void Assign(Student student)
        {
            studentGradeDictionary.Add(student, "");
        }

        public void Grade(Student student, string grade)
        {
            if (!studentGradeDictionary.ContainsKey(student))
                throw new UnassignedStudentException();
            studentGradeDictionary[student] = grade;
        }

        public Dictionary<string, int> GenerateStatistics()
        {
            var gradeCountDictionary = new Dictionary<string, int>();
            gradeCountDictionary.Add("IG", 0);
            gradeCountDictionary.Add("G", 0);
            gradeCountDictionary.Add("VG", 0);
            foreach (var studentGradeEntry in studentGradeDictionary)
            {
                gradeCountDictionary[studentGradeEntry.Value]++;
            }
            return gradeCountDictionary;
        }
    }
}
