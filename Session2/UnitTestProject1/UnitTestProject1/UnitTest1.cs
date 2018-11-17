using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThatGridExist()
        {
            //Given a new game of Life
            var gameOfLife = new GameOfLife();
            //Check for the existance of a grid
            var grid = gameOfLife.Grid;
            Assert.AreNotSame(grid, null);
        }
        [TestMethod]
        public void TestThatCellsExist()
        {
            //Given a new game of Life
            var gameOfLife = new GameOfLife();
            //Given a new Game of Life Grid
            //Check for the existance of a cell
            var cell = gameOfLife.Grid.GetCell();
            Assert.AreNotSame(cell, null);
        }
        [TestMethod]
        public void TestThatCellsOn()
        {
            //Given a new game of Life
            var gameOfLife = new GameOfLife();
            //Given a new Game of Life Grid
            //Check for the cell is on
            var cell = gameOfLife.Grid.GetCell();
            var active = cell.IsOn;
            Assert.AreEqual(active, true);
        }

        [TestMethod]
        public void TestThatTurningCellOffReturnsOff()
        {
            var gameOfLife = new GameOfLife();
            //Check that after a cell is turned off, it is off
            var cell = gameOfLife.Grid.GetCell();
            cell.TurnOff();
            var active = cell.IsOn;
            Assert.AreEqual(active, false);
        }


    }

    internal class GameOfLife
    {
        public GameOfLife()
        {
            Grid = new gRidClass();
        }

        public gRidClass Grid { get; internal set; }
    }

    public class gRidClass
    {
        internal Cell GetCell()
        {
            return new Cell();

        }
    }
}

