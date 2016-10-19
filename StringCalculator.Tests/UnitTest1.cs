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

        [TestMethod]
        public void Add_MultipleNumbers_WithDiffSeparator_ReturnSumResult()
        {
            sc.Add("1;2");
            Assert.AreEqual(sc.Result, 3);
        }

        [TestMethod]
        public void Add_MultipleNumbers_WithNewLineSeparator_ReturnSumResult()
        {
            sc.Add("1\n2");
            Assert.AreEqual(sc.Result, 3);
        }

        [TestMethod]
        public void Add_MultipleNumbers_WithMultipleSeparator_ReturnSumResult()
        {
            sc.Add("1\n2,3;3");
            Assert.AreEqual(sc.Result, 9);
        }

        [TestMethod]
        public void Add_NegativeNumber_Return()
        {
            //sc.Add("-1");
        }

        [TestMethod]
        public void Add_SomeNegativeNumbers_Return()
        {
            //sc.Add("-1;2;-5");
        }

        [TestMethod]
        public void Add_BiggerNumber_Return()
        {
            sc.Add("2;1001");
            Assert.AreEqual(sc.Result, 2);
        }
    }
}
