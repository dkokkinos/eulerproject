using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P11_LargestProductInaGrid
{
    public class LargestProductInAGridSolver
    {
        private readonly int _adjusent;
        private readonly List<NumberParserStrategy> _parserStrategies;
        private readonly IOperation _operation;

        public LargestProductInAGridSolver(int adjusent,
            List<NumberParserStrategy> parserStrategies,
            IOperation operation)
        {
            _adjusent = adjusent;
            _operation = operation;
            _parserStrategies = parserStrategies;
        }

        public List<NumberParserStrategy> Solve(int[,] matrix)
        {
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    CalculateAdjusency(y, x, matrix);
                }
            }

            return this._parserStrategies;
        }

        private void CalculateAdjusency(int y, int x, int[,] matrix)
        {
            foreach (var numberParserStrategy in this._parserStrategies)
            {
                if (!numberParserStrategy.IsInBounds(x, y, _adjusent, matrix))
                    continue;
                var numbers = numberParserStrategy.GetNumbers(x, y, _adjusent, matrix);
                var result = _operation.Calculate(numbers);

                if (!numberParserStrategy.Max.HasValue || numberParserStrategy.Max < result)
                    numberParserStrategy.UpdateMax(result, numbers);
            }
        }

    }
}
