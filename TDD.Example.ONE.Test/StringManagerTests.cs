using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Example.ONE.Test
{
    [TestClass]
    public class StringManagerTests
    {
        [TestMethod]
        public void sm_CheckWithoutContent()
        {
            var sm = new StringManager();

            Assert.IsTrue(sm.IsNullOrEmpty);
        }

        [TestMethod]
        public void sm_CheckStringAdd()
        {
            var sm = new StringManager();

            var _s = "Roberto";

            Assert.AreEqual(sm.Add(_s).ToString(), _s);
        }

        [TestMethod]
        public void sm_CheckRemoveString()
        {
            var sm = new StringManager("Roberto Beccari");

            Assert.AreEqual(sm.Remove("Beccari").ToString(), "Roberto ");
        }
    }
}
