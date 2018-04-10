using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P14_LongestCollatzSequence
{
    public interface IGenerator
    {
        long Next(long x);
    }
}
