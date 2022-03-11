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
            int matrixX = matrix.GetLength(1);
            int x_diff = matrixX - x;
            int y_diff = y+1 - adjacent;

            if (x_diff >= adjacent && y_diff >= 0)
                return true;
            return false;
        }

        public override int[] GetNumbers(int x, int y, int adjacent, int[,] matrix)
        {
            int [] res = new int[adjacent];
            for (int a = 0; a < adjacent; a++)
            {
                res[a] = matrix[y, x];
                x++;
                y--;
            }
            return res;
        }

        public override string ToString()
        {
            return nameof(Diagonal45DegreesNumberParser);
        }
    }
}
