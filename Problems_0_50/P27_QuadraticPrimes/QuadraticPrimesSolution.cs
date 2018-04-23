using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Problems_0_50.P27_QuadraticPrimes
{
    public class QuadraticPrimesSolution : ISolvable
    {
        public void Solve()
        {
            List<int> ns = this.GetPrimesInRange(-1000, 1000);
            int max = 0;
            int product = 0;
            foreach (var a in ns)
            {
                foreach (var b in ns)
                {
                    List<int> primes = this.FindSequencialyPrimeNumbers(a, b);
                    if (primes.Count > max)
                    {
                        max = primes.Count;
                        product = a * b;
                    }
                }
            }

            Console.WriteLine("the maximum number of primes is " + max + " and the product of a is " + product);

        }

        private List<int> FindSequencialyPrimeNumbers(int a, int b)
        {
            List<int> res = new List<int>();
            for (int n = 0; n <= b; n++)
            {
                int r = n * n + a * n + b;
                if (!this.IsPrime(Math.Abs(r)))
                    return res;
                res.Add(r);
            }
            return res;
        }

        List<int> GetPrimesInRange(int from, int to)
        {
            List<int> res = new List<int>();
            for (int i = from; i <= to; i++)
            {
                if (this.IsPrime(Math.Abs(i)))
                    res.Add(i);
            }
            return res;
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
