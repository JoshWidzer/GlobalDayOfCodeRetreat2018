using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GameOfLife
    {
        private int width;
        private int height;
        private bool[,] grid;

        public GameOfLife(int width, int height)
        {
            this.width = width;
            this.height = height;
            grid = new bool[height, width];
        }

        public void TakeTurn()
        {
            //
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    if (grid[x,y])
                    sb.Append("_ ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public void TurnCellOn(int row, int column)
        {
            grid[row, column] = true;
        }
    }
}
