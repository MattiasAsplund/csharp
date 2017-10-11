using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Security.Cryptography;

namespace HashesTests
{
    [TestClass]
    public class FileComparisonTests
    {
        [TestMethod]
        public void FilesAreEqual()
        {
            byte[] fileOne = File.ReadAllBytes("hello1.txt");
            byte[] fileTwo = File.ReadAllBytes("hello2.txt");
            var alg = SHA512.Create();
            byte[] fileOneHash = alg.ComputeHash(fileOne);
            byte[] fileTwoHash = alg.ComputeHash(fileTwo);
            Assert.IsTrue(HashesAreEqual(fileOneHash, fileTwoHash));
        }

        [TestMethod]
        public void FilesAreDifferent()
        {
            byte[] fileOne = File.ReadAllBytes("hello1.txt");
            byte[] fileTwo = File.ReadAllBytes("hello3.txt");
            SHA1 alg = SHA1.Create();
            byte[] fileOneHash = alg.ComputeHash(fileOne);
            byte[] fileTwoHash = alg.ComputeHash(fileTwo);
            Assert.IsFalse(HashesAreEqual(fileOneHash, fileTwoHash));
        }

        private bool HashesAreEqual(byte[] fileOneHash, byte[] fileTwoHash)
        {
            for (var pos = 0; pos < fileOneHash.Length; pos++)
            {
                if (fileOneHash[pos] != fileTwoHash[pos])
                    return false;
            }
            return true;
        }
    }
}
