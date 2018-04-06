using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P7_10001st_prime
{
    public class _10001stPrimeSolution : ISolvable
    {
        public void Solve()
        {
            int limit = 10001;

            int currCounter = 0;
            int lastPrimeNumber = -1;
            for(int i = 2; i < int.MaxValue; i++)
            {
                if (this.IsPrime(i))
                {
                    currCounter++;
                    if(currCounter == limit)
                    {
                        lastPrimeNumber = i;
                        break;
                    }
                }
            }

            Console.WriteLine($"the {limit}th prime number is:{lastPrimeNumber}");

        }

        private bool IsPrime(int number)
        {
            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
