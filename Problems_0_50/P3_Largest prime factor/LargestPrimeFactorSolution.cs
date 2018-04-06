using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.Largest_prime_factor
{
    public class LargestPrimeFactorSolution : ISolvable
    {
        private readonly long _number = 600851475143;

        public void Solve()
        {
            int maxPrimeFactor = 1;
            long currentTarget = this._number;

            for(int divider = 2; divider < Math.Sqrt(this._number ); divider++)
            {
                if(currentTarget % divider == 0)
                {
                    maxPrimeFactor = divider;
                    currentTarget = currentTarget / divider;
                    if (currentTarget == 1)
                        break;
                    //divider = 2;
                }
            }

            Console.WriteLine($"the maximum prime factor of {this._number} is {maxPrimeFactor}");

        }
    }
}
