using System;
using Problems_0_50.P15_LatticePaths.Structures.Directions;

namespace Problems_0_50.P15_LatticePaths.Structures
{
    public class Map
    {
        public Node Start { get; set; }
        public Node End { get; set; }

        public Node [,] Nodes;

        public Map(Size size)
        {
            this.Nodes = new Node[size.X, size.Y];

            for (int i = 0; i < size.X; i++)
            {
                for (int j = 0; j < size.Y; j++)
                {
                    this.Nodes[i,j] = new Node(new Point(i, j));        
                }
            }

        }

        public bool Connect(Node from, Node to)
        {
       
            if (to.IsUpFrom(from))
            {
                from.AddDirection(new UpDirection(to));
            }else if (to.IsDownFrom(from))
            {
                from.AddDirection(new DownDirection(to));
            }else if (to.IsLeftFrom(from))
            {
                from.AddDirection(new LeftDirection(to));
            }else if (to.IsRightFrom(from))
            {
                from.AddDirection(new RightDirection(to));
            }
            else
            {
                return false;
            }

            return true;
        }
        

    }
}
