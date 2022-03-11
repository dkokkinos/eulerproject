using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P11_LargestProductInaGrid
{
    public class VerticalNumberParser : NumberParserStrategy
    {
        public override int[] GetNumbers(int x, int y, int adjacent, int[,] matrix)
        {
            int[] res = new int[adjacent];
            for (int index = 0; index < adjacent; index++)
            {
                res[index] = matrix[y, x];
                y++;
            }
            return res;
        }

        public override bool IsInBounds(int x, int y, int adjacent, int[,] matrix)
        {
            int y_diff = matrix.GetLength(0) - y;
            if (y_diff >= adjacent)
                return true;
            return false;
        }

        public override string ToString()
        {
            return nameof(VerticalNumberParser);
        }
    }
}
