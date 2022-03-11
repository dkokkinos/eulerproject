using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Problems_0_50.P11_LargestProductInaGrid
{
    public class LargestProductInaGridSolution : ISolvable
    {
        private static string nl = Environment.NewLine;
        private const int Adjusent = 4;

        private string _matrix = "08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08" + nl +
                                 "49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00" + nl +
                                 "81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65" + nl +
                                 "52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91" + nl +
                                 "22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80" + nl +
                                 "24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50" + nl +
                                 "32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70" + nl +
                                 "67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21" + nl +
                                 "24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72" + nl +
                                 "21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95" + nl +
                                 "78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92" + nl +
                                 "16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57" + nl +
                                 "86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58" + nl +
                                 "19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40" + nl +
                                 "04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66" + nl +
                                 "88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69" + nl +
                                 "04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36" + nl +
                                 "20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16" + nl +
                                 "20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54" + nl +
                                 "01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48";


        //private string _matrix = "1  2  3  4  2" + nl +
        //                         "5  6  7  8  2" + nl +
        //                         "9  10 11 12 2" + nl +
        //                         "13 14 15 16 2";

        public void Solve()
        {
            int[,] matrix = this.ConvertMatrixToArray(this._matrix);
            List<NumberParserStrategy> parserStrategies = new List<NumberParserStrategy>()
            {
                new Diagonal45DegreesNumberParser(),
                new Diagonal135DegreesNumberParser(),
                new VerticalNumberParser(),
                new HorizontalNumberParser()
            };
            int max = 0;

            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    foreach (var numberParserStrategy in parserStrategies)
                    {
                        if(!numberParserStrategy.IsInBounds(x, y, Adjusent, matrix))
                            continue;
                        var numbers = numberParserStrategy.GetNumbers(x, y, Adjusent, matrix);
                        var result = MakeOperation(numbers);
                        if (max < result)
                        {
                            max = result;
                            numberParserStrategy.UpdateMax(max, numbers);
                        }
                    }
                }
            }

            var parser = parserStrategies.OrderByDescending(x => x.Max).First();
            Console.WriteLine(parser.AsString());
          
        }

        private int MakeOperation(int[] numbers)
        {
            return numbers.Aggregate(1, (current, number) => current*number);
        }

        private int[,] ConvertMatrixToArray(string m)
        {
            string[] rows = m.Split( new[] {Environment.NewLine}, StringSplitOptions.None );

            int[,] res = new int[ rows.Length, rows[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Count()];

            int rowIndex = 0;
            int columnIndex = 0;
            foreach (var row in rows)
            {
                string[] columns = row.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var x in columns)
                {
                    res[rowIndex, columnIndex] = Convert.ToInt32(x);
                    columnIndex++;
                }
                rowIndex++;
                columnIndex = 0;
            }

            return res;
        }

    }
}
