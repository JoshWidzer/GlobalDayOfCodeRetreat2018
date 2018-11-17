namespace UnitTestProject1
{
    internal class Cell
    {
        private int numNeighbors;
        private bool isAlive;

        public Cell()
        {
        }

        public int NumOnNeighbors { get => numNeighbors; set => numNeighbors = value; }
        public bool IsAlive { get => isAlive; set => isAlive = value; }

        public bool NextState()
        {
            bool threeNeighbors = numNeighbors == 3;
            bool survival = (numNeighbors == 2 && isAlive);
            return survival || threeNeighbors;
        }
    }
}
