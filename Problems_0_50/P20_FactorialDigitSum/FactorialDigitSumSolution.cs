using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P20_FactorialDigitSum
{
    public class FactorialDigitSumSolution : ISolvable
    {
        public void Solve()
        {
            int number = 100;

            BigInteger res = new BigInteger();
            res = this.Factorial(number);

            int sum = 0;
            foreach(var s in res.ToString())
            {
                sum += Convert.ToInt32(s.ToString());
            }
            Console.WriteLine("the sum is " + sum);
        }

        private BigInteger Factorial(BigInteger number)
        {
            if (number == 0)
                return 1;
            else if(number == 1)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}
