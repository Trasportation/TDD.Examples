using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Tests
{
    [TestClass]
    public class BowlingGameTest
    {
        Game g;
        public BowlingGameTest()
        {
            g = new Game();
        }

        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                g.Roll(pins);
        }

        private void rollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }

        private void rollStrike()
        {
            g.Roll(10);
        }

        [TestMethod]
        public void testGutterGame()
        {
            rollMany(20, 0);

            Assert.AreEqual(0, g.Score());
        }

        [TestMethod]
        public void testAllOnes()
        {
            rollMany(20, 1);
            Assert.AreEqual(20, g.Score());
        }

        [TestMethod]
        public void testOneSpare()
        {
            rollSpare();
            g.Roll(3);
            rollMany(17, 0);
            Assert.AreEqual(16, g.Score());
        }

        [TestMethod]
        public void testOneStrike()
        {
            rollStrike();
            g.Roll(3);
            g.Roll(4);

            rollMany(17, 0);

            Assert.AreEqual(24, g.Score());
        }

        [TestMethod]
        public void testPerfectGame()
        {
            rollMany(12, 10);
            Assert.AreEqual(300, g.Score());
        }
    }
}
