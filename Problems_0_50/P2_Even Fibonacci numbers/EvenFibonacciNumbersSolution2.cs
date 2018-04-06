using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P2_Even_Fibonacci_numbers
{
    public class EvenFibonacciNumbersSolution2 : ISolvable
    {
        public void Solve()
        {
            List<int> numbers = new List<int>();

            int answer = 0;

            numbers.Add(1);
            numbers.Add(2);

            do
            {
                numbers.Add(numbers[numbers.Count - 2] + numbers[numbers.Count - 1]);
            } while (numbers[numbers.Count - 2] + numbers[numbers.Count - 1] < 4000000);

            foreach (int number in numbers) if (number % 2 == 0) answer += number;

            Console.WriteLine($"\nanswer: {answer}");
        }
    }
}
