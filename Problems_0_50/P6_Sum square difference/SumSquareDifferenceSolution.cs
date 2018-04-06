using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P6_Sum_square_difference
{
    public class SumSquareDifferenceSolution : ISolvable
    {
        public void Solve()
        {
            int n = 100;
            int sum_squared = ((n * (n + 1)) / 2)* ((n * (n + 1)) / 2);
            int squared_sum = (n * (n + 1) * (2 * n + 1)) / 6;

            Console.WriteLine($"the difference between squared sum:{squared_sum} and the sum squared: {sum_squared} of first {n} numbers is: {sum_squared - squared_sum }");

        }
    }
}
