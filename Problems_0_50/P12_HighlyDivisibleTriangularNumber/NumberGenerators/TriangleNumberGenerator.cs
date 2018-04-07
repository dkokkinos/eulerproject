using System.Collections.Generic;

namespace Problems_0_50.P12_HighlyDivisibleTriangularNumber.NumberGenerators
{
    public class TriangleNumberGenerator : INumberGenerator
    {
        public IEnumerable<int> Numbers
        {
            get
            {
                for (int n = 0; n < int.MaxValue; n++)
                {
                    int res = n * (n + 1) / 2;
                    yield return res;
                }
            }
        }

    }
}
