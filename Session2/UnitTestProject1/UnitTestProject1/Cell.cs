using System;

namespace UnitTestProject1
{
    internal class Cell
    {
        public bool IsOn { get { return cellState; }}
        bool cellState = true;

        internal void TurnOff()
        {
            cellState = false;
        }
    }
}