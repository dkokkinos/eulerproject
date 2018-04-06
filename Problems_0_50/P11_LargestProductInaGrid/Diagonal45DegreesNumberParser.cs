using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P11_LargestProductInaGrid
{
    public class Diagonal45DegreesNumberParser : NumberParserStrategy
    {
        public override bool IsInBounds(int x, int y, int adjacent, int[,] matrix)
        {
            int x_diff = matrix.GetLength(0) - x;
            int y_diff = matrix.GetLength(1) - y;
            if (x_diff < adjacent || y_diff < adjacent)
                return false;
            return true;
        }

        public override int[] GetNumbers(int x, int y, int adjacent, int[,] matrix)
        {
            int [] res = new int[adjacent];
            for (int a = 0; a < adjacent; a++)
            {
                res[a] = matrix[x, y];
                x++;
                y++;
            }
            return res;
        }

        public override string ToString()
        {
            return nameof(Diagonal45DegreesNumberParser);
        }
    }
}
