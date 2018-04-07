using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P12_HighlyDivisibleTriangularNumber
{
    public interface INumberGenerator
    {
        IEnumerable<int> Numbers { get; }
    }
}
