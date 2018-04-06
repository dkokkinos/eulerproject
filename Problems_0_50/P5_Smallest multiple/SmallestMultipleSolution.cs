using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P5_Smallest_multiple
{
    public class SmallestMultipleSolution : ISolvable
    {
        public void Solve()
        {
            int[] numbers = new int[] {
                1,2,3,4,5,6,7,8,9,10,
                11,12,13,14,15,16,17,18,19,20,
            };
            int limit = 1000000000;
            int smallestEvenlyDivisibleNumber = 1;
            for(int i = numbers.Max(); i < limit; i+=5)
            {
                if (IsDivisibleByAll(i, numbers))
                {
                    smallestEvenlyDivisibleNumber = i;
                    break;
                }
            }

            Console.WriteLine($"the smallest evenly divisible number is {smallestEvenlyDivisibleNumber}");

        }

        private bool IsDivisibleByAll(int number, int[] numbers)
        {
            foreach(var n in numbers)
            {
                if (number % n != 0)
                    return false;
            }
            return true;
        }
    }
}
