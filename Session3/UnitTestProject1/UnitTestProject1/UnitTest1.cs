using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCellReproduction
    {
        [TestMethod]
        public void Underpopulation()
        {
            CheckIsAlive(false, true, 1);
        }

        [TestMethod]
        public void Survival2()
        {
            CheckIsAlive(true, true, 2);
        }

        [TestMethod]
        public void Survival3()
        {
            CheckIsAlive(true, true, 3);
        }

        [TestMethod]
        public void Overcrowding()
        {
            CheckIsAlive(false, true, 6);
        }

        [TestMethod]
        public void reproduction()
        {
            CheckIsAlive(true, false, 3);
        }

        private static void CheckIsAlive(bool Expected, bool isCurrentlyAlive, int numNeighbors)
        {
            var cell = new Cell();
            cell.IsAlive = isCurrentlyAlive;
            cell.NumOnNeighbors = numNeighbors;
            var next = cell.NextState();
            Assert.AreEqual(Expected, next);
        }
    }
}
