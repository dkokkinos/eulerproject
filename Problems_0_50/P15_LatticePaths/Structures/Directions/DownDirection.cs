﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P15_LatticePaths.Structures.Directions
{
    public class DownDirection : Direction
    {
        public DownDirection( Node destination) : base("down", destination)
        {
        }
    }
}
