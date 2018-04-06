using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P2_Even_Fibonacci_numbers
{
    public class EvenFibonacciNumbersSolution : ISolvable
    {
        static int numberOfTerms = 32;
        int[] numbers = new int[numberOfTerms];

        public void Solve()
        {
            
            fibonacci(numberOfTerms - 1);
           
            Console.WriteLine($"the first {numberOfTerms} of the fibonacci sequence are {numbers.Aggregate("", (accumulator, piece) => accumulator + "," + piece)}");

            List<int> even = this.numbers.Where(x => x % 2 == 0).ToList();
            Console.WriteLine($"the even numbers are {even.Aggregate("", (accumulator, piece) => accumulator + "," + piece)}");
            Console.WriteLine($"the sum of the last values are: {even.Sum()}");
        }

        private int fibonacci(int n)
        {
            return this.f(n);
        }

        private int f(int n)
        {
            if (n == 0)
            {
                this.numbers[n] = 1;
                return 1;
            }
            else if (n == 1)
            {
                this.numbers[n] = 2;
                return 2;
            }
            numbers[n - 2] = f(n - 2);
            numbers[n - 1] = f(n - 1);
            numbers[n] = numbers[n - 1] + numbers[n - 2];
            return numbers[n];
        }
    }
}
