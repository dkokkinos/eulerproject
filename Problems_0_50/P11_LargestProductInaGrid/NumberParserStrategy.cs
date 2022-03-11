using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P11_LargestProductInaGrid
{
    public abstract class NumberParserStrategy
    {
        public int? Max { get; private set; }
        public int[] Numbers { get; private set; }

        public abstract int[] GetNumbers(int x, int y, int adjacent, int[,] matrix);
        public abstract bool IsInBounds(int x, int y, int adjacent, int[,] matrix);

        public void UpdateMax(int max, int[] numbers)
        {
            this.Max = max;
            this.Numbers = numbers;
        }

        public string AsString()
        {
            return $"{GetType()}: {(this.Max.HasValue ? $"Max:{this.Max.Value} [{string.Join(",", Numbers)}]" : "There is no max")}";
        }
    }
}
