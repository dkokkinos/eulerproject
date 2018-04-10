using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P14_LongestCollatzSequence.Generators
{
    public class ThreeNPlusOneGenerator : IGenerator
    {
        public long Next(long x)
        {
            return 3*x + 1;
        }
    }
}
