using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamLib;
using System.Collections.Generic;

namespace ExamTestsLib
{
    [TestClass]
    public class ExamTests
    {
        [TestMethod]
        public void Statistics()
        {
            var anExam = new Exam("CSharp");
            var alice = new Student("Alice");
            var bob = new Student("Bob");
            var caesar = new Student("Caesar");
            anExam.Assign(alice);
            anExam.Assign(bob);
            anExam.Assign(caesar);
            anExam.Grade(alice, "G");
            anExam.Grade(bob, "VG");
            anExam.Grade(caesar, "G");
            Dictionary<string, int> statistics = anExam.GenerateStatistics();
            Assert.AreEqual(statistics["IG"], 0);
            Assert.AreEqual(statistics["G"], 2);
            Assert.AreEqual(statistics["VG"], 1);
        }
        [TestMethod]
        [ExpectedException(typeof(UnassignedStudentException))]
        public void UnassignedStudent()
        {
            var sut = new Exam("CSharp");
            Student alice = new Student("Alice");
            Student bob = new Student("Bob");
            anExam.RegisterResult(alice, "G");
        }

    }
}
