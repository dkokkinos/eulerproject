using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Problems_0_50.P28_NumberSpiralDiagonals
{
    public class NumberSpiralDiagonalsSolution : ISolvable
    {
        public void Solve()
        {
            int matrixSize = 1001;

            int _ref = 1;
            int sum = _ref;
            for (int disk = 1; disk <= matrixSize / 2; disk++)
            {
                int inc = this.DiskIncrementFactor(disk);
                int downRight = _ref + disk + inc / 2;
                int downLeft = downRight + inc;
                int upLeft = downLeft + inc;
                int upRight = upLeft + inc;

                sum += downRight + downLeft + upLeft + upRight;
                _ref = upRight;
            }

            Console.WriteLine("the sum of diagonals in a " + matrixSize + "x" + matrixSize + " matrix is " + sum);
        }

        private int DiskIncrementFactor(int disk)
        {
            return disk * 2;
        }
    }
}
