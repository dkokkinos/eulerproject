using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.Multiplesof3and5
{
    public class Multiplesof3and5Solution : ISolvable
    {
        public void Solve()
        {
            FiveMultiple five = new FiveMultiple() {
                Successor = new NullMultiple()
            };
            ThreeMultiple three = new ThreeMultiple() {
                Successor = five
            };

            int limit = 1000;
            List<int> numbers = new List<int>();
            for (int i = 1; i < limit; i++)
            {
                if (three.IsDivisible(i))
                    numbers.Add(i);
            }

            Console.WriteLine($"multiples below {limit} are {numbers.Aggregate("", (accumulator, piece) => accumulator + "," + piece)}");

            Console.WriteLine(numbers.Sum());

        }
    }
}
