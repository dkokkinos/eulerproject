using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P11_LargestProductInaGrid
{
    public class Diagonal135DegreesNumberParser : NumberParserStrategy
    {
        public override int[] GetNumbers(int x, int y, int adjacent, int[,] matrix)
        {
            int [] res = new int[adjacent];
            for (int i = 0; i < adjacent; i++)
            {
                res[i] = matrix[x, y];
                x++;
                y--;
            }
            return res;
        }

        public override bool IsInBounds(int x, int y, int adjacent, int[,] matrix)
        {
            int x_diff = matrix.GetLength(0) - x;
            if (y < adjacent || x_diff < adjacent)
                return false;
            return true;
        }

        public override string ToString()
        {
            return nameof(Diagonal135DegreesNumberParser);
        }
    }
}
