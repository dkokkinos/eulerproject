using System;
using System.Collections.Generic;
using Problems_0_50.P15_LatticePaths.Structures.Directions;

namespace Problems_0_50.P15_LatticePaths.Structures
{
    public class Node
    {
        public Point Position { get; private set; }
        public List<Direction> Directions { get; set; }

        public Node(Point pos)
        {
            this.Position = pos;
            this.Directions = new List<Direction>();
        }

        public bool IsUpFrom(Node node)
        {
            return this.Position.Y < node.Position.Y;
        }

        public bool IsDownFrom(Node node)
        {
            return this.Position.Y > node.Position.Y;
        }

        public bool IsLeftFrom(Node node)
        {
            return this.Position.X < node.Position.X;
        }

        public bool IsRightFrom(Node node)
        {
            return this.Position.X > node.Position.X;
        }

        internal void AddDirection(Direction direction)
        {
            this.Directions.Add(direction);
        }

        public override string ToString()
        {
            return $"({this.Position.X},{this.Position.Y})";
        }
    }
}
