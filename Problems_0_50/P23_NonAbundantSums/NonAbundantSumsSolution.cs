using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P23_NonAbundantSums
{
    public class NonAbundantSumsSolution : ISolvable
    {
        public void Solve()
        {
            List<int> abundantNumbers = this.FindAbundantNumbers(1, 28124).ToList();
            List<int> integers = this.FindNumbersWhichisSumOf(abundantNumbers);
            List<int> numbers = this.GetNumbersNotInList(28124, integers);
            long sum = numbers.Sum();
        }

        private List<int> GetNumbersNotInList(int limit, List<int> list)
        {
            List<int> res = new List<int>();
            for(int i = 1; i < limit; i++)
            {
                if (list.Contains(i))
                    continue;
                res.Add(i);
            }
            return res;
        }

        private List<int> FindNumbersWhichisSumOf(List<int> abundantNumbers)
        {
            SortedSet<int> res = new SortedSet<int>();
            for (int i = 0; i < abundantNumbers.Count; i++)
            {
                for (int j = 0; j < abundantNumbers.Count; j++)
                {
                    res.Add(abundantNumbers[i] + abundantNumbers[j]);
                }
            }
            return res.ToList();
        }

        private bool IsNumberSumOf(int number, IEnumerable<int> numbers)
        {
            for(int i = 0; i < numbers.Count();  i++)
            {
                for(int j = i; j < numbers.Count(); j++)
                {
                    if (numbers.ElementAt(i) + numbers.ElementAt(j) == number)
                        return true;
                }
            }

            return false;
        }

        private IEnumerable<int> FindAbundantNumbers(int from, int to)
        {
        
            for (int number = from; number < to; number++)
            {
                if (this.IsAbundant(number))
                    yield return number;
            }

        }

        bool IsAbundant(int number)
        {
            int sumOfProperDivisors = this.ProperDivisors(number).Sum();
            if (number < sumOfProperDivisors)
                return true;
            return false;
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
