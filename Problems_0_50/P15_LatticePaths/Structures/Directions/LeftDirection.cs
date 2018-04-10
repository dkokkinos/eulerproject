using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P15_LatticePaths.Structures.Directions
{
    public class LeftDirection : Direction
    {
        public LeftDirection( Node destination) : base("left", destination)
        {
        }
    }
}
