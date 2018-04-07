using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P12_HighlyDivisibleTriangularNumber.ConditionCheckers
{
    public class CounterConditionChecker : IConditionChecker
    {
        private readonly int _count;

        public CounterConditionChecker(int count)
        {
            this._count = count;
        }

        public bool Check(List<int> numbers)
        {
            if (numbers.Count > this._count)
                return true;
            return false;
        }
    }
}
