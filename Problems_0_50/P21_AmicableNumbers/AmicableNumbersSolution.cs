using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P21_AmicableNumbers
{
    public class AmicableNumbersSolution : ISolvable
    {
        public AmicableNumbersSolution()
        {
            this._numberSumCache = new Dictionary<int, int>();
        }

        public void Solve()
        {
            int limit = 10000;
            long sum = 0;
            for (int i = 2; i < limit; i++)
            {
                for (int j = i + 1; j < limit; j++)
                {
                    if (this.AreAmicable(i, j))
                    {
                        sum += i + j;
                    }
                }
            }

            Console.WriteLine("the sum of all amicable numbers under " + limit + " is " + sum);
        }

        private bool AreAmicable(int number1, int number2)
        {
            return this.SumOfProperDivisors(number1) == number2 && number1 == this.SumOfProperDivisors(number2);
        }

        private readonly Dictionary<int, int> _numberSumCache;
        private int SumOfProperDivisors(int number)
        {
            if (this._numberSumCache.ContainsKey(number))
            {
                return _numberSumCache[number];
            }
            int res = this.ProperDivisors(number).Sum();
            this._numberSumCache.Add(number, res);
            return res;
        }

        private IEnumerable<int> ProperDivisors(int number)
        {
            yield return 1;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    yield return i;
            }
        }

    }
}
