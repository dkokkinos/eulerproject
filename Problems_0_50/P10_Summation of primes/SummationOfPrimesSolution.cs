using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.Summation_of_primes
{
    public class SummationOfPrimesSolution : ISolvable
    {
        public void Solve()
        {
            int max = 2000000;
            long sum = 0;
            for(int i = 2; i < max; i++)
            {
                if (this.IsPrime(i))
                    sum += i;
            }

            Console.WriteLine($"the sum of all primes below {max} is {sum}");
        }

        private bool IsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
