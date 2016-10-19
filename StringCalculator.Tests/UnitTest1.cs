using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator.Tests
{
    [TestClass]
    public class StringCalculatorUnitTest
    {
        StringCalculator sc = new StringCalculator();

        [TestMethod]
        public void Add_SingleNumber_Return1()
        {
            sc.Add("1");
            Assert.AreEqual(sc.Result, 1);
        }

        [TestMethod]
        public void Add_SingleNumber_ReturnSumResult()
        {
            sc.Add("1");
            sc.Add("1");
            Assert.AreEqual(sc.Result, 2);
        }

        [TestMethod]
        public void Add_MultipleNumbers_ReturnSumResult()
        {
            sc.Add("1,2");
            Assert.AreEqual(sc.Result, 3);
        }
    }
}
