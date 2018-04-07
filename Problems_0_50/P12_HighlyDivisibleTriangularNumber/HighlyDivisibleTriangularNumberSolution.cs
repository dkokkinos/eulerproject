using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Problems_0_50.P12_HighlyDivisibleTriangularNumber.ConditionCheckers;
using Problems_0_50.P12_HighlyDivisibleTriangularNumber.NumberBreakers;
using Problems_0_50.P12_HighlyDivisibleTriangularNumber.NumberGenerators;

namespace Problems_0_50.P12_HighlyDivisibleTriangularNumber
{
    public class HighlyDivisibleTriangularNumberSolution : ISolvable
    {
        public void Solve()
        {
            int threshold = 500;

            INumberGenerator numberGenerator = new TriangleNumberGenerator();
            INumberBreaker numberBreaker = new DivisorNumberBreaker();
            IConditionChecker condition = new CounterConditionChecker(threshold);
            
            foreach (var i in numberGenerator.Numbers)
            {
                List<int> parts = numberBreaker.BreakNumber(i);
                if (condition.Check(parts))
                {
                    this.Print(i);
                    break;
                }
            }
        }

        public void Print(int number)
        {
            Console.WriteLine($"found {number}");
        }
    }
}
