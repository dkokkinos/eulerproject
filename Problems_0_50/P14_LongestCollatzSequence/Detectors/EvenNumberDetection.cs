﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P14_LongestCollatzSequence.Detectors
{
    public class EvenNumberDetection : IDetection
    {
        public bool Check(long number)
        {
            return number%2 == 0;
        }
    }
}
