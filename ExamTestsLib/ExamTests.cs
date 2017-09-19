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
            var sut = new Exam("CSharp");
            var alice = new Student("Alice");
            var bob = new Student("Bob");
            var caesar = new Student("Caesar");
            sut.Assign(alice);
            sut.Assign(bob);
            sut.Assign(caesar);
            sut.Grade(alice, "G");
            sut.Grade(bob, "VG");
            sut.Grade(caesar, "G");
            Dictionary<string, int> statistics = sut.GenerateStatistics();
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
            sut.Grade(alice, "G");
        }

    }
}
