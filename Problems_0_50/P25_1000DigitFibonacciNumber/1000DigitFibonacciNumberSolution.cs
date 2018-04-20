using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Problems_0_50.P25_1000DigitFibonacciNumber
{
    public class _1000DigitFibonacciNumberSolution : ISolvable
    {
        public void Solve()
        {
            BigInteger[] n = new BigInteger[2] { 1, 1 };

            int counter = 3;
            int digits = 1000;
            while (true)
            {
                BigInteger newNumber = n[1] + n[0];
                n[0] = n[1];
                n[1] = newNumber;
                if (newNumber.ToString().Length == digits)
                {
                    break;
                }
                counter++;
            }

            Console.WriteLine("The index of the first number contains " + digits + " is " + counter);

        }

    }
}
