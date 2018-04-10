namespace Problems_0_50.P15_LatticePaths.Structures
{
    public abstract class Direction
    {
        public Node Destination { get; private set; }
        public string Name { get; set; }

        protected Direction(string name, Node destination)
        {
            this.Name = name;
            this.Destination = destination;
        }
    }
}
