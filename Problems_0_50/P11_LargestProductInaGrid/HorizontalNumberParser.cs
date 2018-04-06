using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P11_LargestProductInaGrid
{
    public class HorizontalNumberParser : NumberParserStrategy
    {
        public override int[] GetNumbers(int x, int y, int adjacent, int[,] matrix)
        {
            int[] res = new int[adjacent];
            for (int a = 0; a < adjacent; a++)
            {
                res[a] = matrix[x, y];
                x++;
            }
            return res;
        }

        public override bool IsInBounds(int x, int y, int adjacent, int[,] matrix)
        {
            int x_diff = matrix.GetLength(0) - x;
            if (x_diff < adjacent)
                return false;
            return true;
        }

        public override string ToString()
        {
            return nameof(HorizontalNumberParser);
        }
    }
}
