using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P11_LargestProductInaGrid.operations
{
    public class SumOperation : IOperation
    {
        public int Calculate(int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
