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
                res[i] = matrix[y, x];
                x--;
                y--;
            }
            return res;
        }

        public override bool IsInBounds(int x, int y, int adjacent, int[,] matrix)
        {
            int x_diff = (x + 1) - adjacent;
            int y_diff = (y + 1) - adjacent;
            if (y_diff >= 0 && x_diff >= 0)
                return true;
            return false;

        }

        public override string ToString()
        {
            return nameof(Diagonal135DegreesNumberParser);
        }
    }
}
