using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Base64;
namespace Base64
{
    [TestClass()]
    public class Base64Tests
    {

        [TestMethod()]
        public void EncodeTestEmpty()
        {
            string supposedValue = "";
            byte[] myBite1 = new byte[] { };
            Assert.AreEqual(supposedValue, Base64.Encode(myBite1));
        }

        [TestMethod()]
        public void EncodeTestLongSameLetters()
        {
            string supposedValue = "oooo";
            byte[] myBite1 = new byte[] { 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0};
            Assert.AreEqual(supposedValue, Base64.Encode(myBite1));
        }

        [TestMethod()]
        public void EncodeTestDiffrentsLetters1()
        {
            string supposedValue = "AQaf";
            byte[] myBite1 = new byte[] { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 1, 1, 1, 1, 1};
            Assert.AreEqual(supposedValue, Base64.Encode(myBite1));
        }
        [TestMethod()]
        public void EncodeTestDiffrentsLetters2()
        {
            string supposedValue = "z3+1";
            byte[] myBite1 = new byte[] { 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1};
            Assert.AreEqual(supposedValue, Base64.Encode(myBite1));
        }
        [TestMethod()]
        public void EncodeTestDiffrentsLetters3()
        {
            string supposedValue = "0B/9";
            byte[] myBite1 = new byte[] { 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1 };
            Assert.AreEqual(supposedValue, Base64.Encode(myBite1));
        }

        [TestMethod()]
        public void EncodeTestDiffrentsLetters4()
        {
            string supposedValue = "+Aoo0B/9z3+1AQaf";
            byte[] myBite1 = new byte[] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 1, 1, 1, 1, 1 };
            Assert.AreEqual(supposedValue, Base64.Encode(myBite1));
        }
    }
}