using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P11_LargestProductInaGrid
{
    public abstract class NumberParserStrategy
    {
        public abstract int[] GetNumbers(int x, int y, int adjacent, int[,] matrix);
        public abstract bool IsInBounds(int x, int y, int adjacent, int[,] matrix);
    }
}
