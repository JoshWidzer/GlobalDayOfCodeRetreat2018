using System;
using ApprovalTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using ApprovalTests.Reporters;

namespace UnitTestProject1
{
    [TestClass]
    [UseReporter(typeof(DiffReporter))]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyGridResultsInEmptyGrid()
        {
            var gameOfLife = new GameOfLife(4, 4);
            gameOfLife.TakeTurn();
            Approvals.Verify(gameOfLife);
        }

        [TestMethod]
        public void BlockGoesToBlock()
        {
            var gameOfLife = new GameOfLife(4, 4);
            //Turn on cells on in a block on row/columns 2&3
            gameOfLife.TurnCellOn(2, 2);
            gameOfLife.TurnCellOn(2, 3);
            gameOfLife.TurnCellOn(3, 2);
            gameOfLife.TurnCellOn(3, 3);
            gameOfLife.TakeTurn();
            Approvals.Verify(gameOfLife);
        }

    }
}
