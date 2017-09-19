using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib
{
    public class Exam
    {
        private string v;

        public Exam(string v)
        {
            this.v = v;
        }

        public void Assign(object mattias)
        {
            throw new NotImplementedException();
        }

        public void Grade(Student alice, string v)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, int> GenerateStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
