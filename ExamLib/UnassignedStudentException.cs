using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib
{
    public class UnassignedStudentException : ApplicationException
    {
        public UnassignedStudentException()
        {
        }

        public UnassignedStudentException(string message) : base(message)
        {
        }

        public UnassignedStudentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnassignedStudentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
