using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P12_HighlyDivisibleTriangularNumber.NumberGenerators
{
    public class SquaredNumberGenerator : INumberGenerator
    {
        public IEnumerable<int> Numbers
        {
            get
            {
                for (int n = 1; n < int.MaxValue; n++)
                {
                    int res = n * (n + 1) * (2*n + 1) / 6;
                    yield return res;
                }
            }
        }
    }
}
