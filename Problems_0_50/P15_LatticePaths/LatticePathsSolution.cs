using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Problems_0_50.P15_LatticePaths.Structures;

namespace Problems_0_50.P15_LatticePaths
{
    public class LatticePathsSolution : ISolvable
    {

        private Map map;
        private int numberOfRoutes = 0;
        public void Solve()
        {
            this.map = this.GenerateMap();
            func(map.Start);
            Console.WriteLine($"found {numberOfRoutes} routes");
        }

        private Map GenerateMap()
        {
            Map m = new Map(new Size(3,3)) {};
            m.Start = m.Nodes[0, 0];
            m.End = m.Nodes[2, 2];

            m.Connect(m.Nodes[0, 0], m.Nodes[1, 0]);
            m.Connect(m.Nodes[0,0], m.Nodes[0, 1]);

            m.Connect(m.Nodes[1, 0], m.Nodes[2, 0]);
            m.Connect(m.Nodes[1, 0], m.Nodes[1, 1]);

            m.Connect(m.Nodes[0, 1], m.Nodes[1, 1]);

            m.Connect(m.Nodes[1, 1], m.Nodes[2, 1]);

            m.Connect(m.Nodes[2, 0], m.Nodes[2, 1]);

            m.Connect(m.Nodes[0, 1], m.Nodes[0, 2]);
            m.Connect(m.Nodes[0, 2], m.Nodes[1, 2]);
            m.Connect(m.Nodes[1, 1], m.Nodes[1, 2]);

            m.Connect(m.Nodes[2, 1], m.Nodes[2, 2]);
            m.Connect(m.Nodes[1, 2], m.Nodes[2, 2]);

            return m;
        }

        private void func(Node n)
        {
            if (this.map.End == n)
            {
                this.numberOfRoutes++;
                // write route
            }

            foreach (var dir in n.Directions)
            {
                Node dest = dir.Destination;
                func(dest);
            }
            
        } 
        
    }
}
