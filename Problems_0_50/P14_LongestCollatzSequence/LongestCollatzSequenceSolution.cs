using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Interfaces;
using Problems_0_50.P14_LongestCollatzSequence.Detectors;
using Problems_0_50.P14_LongestCollatzSequence.Generators;

namespace Problems_0_50.P14_LongestCollatzSequence
{
    public class LongestCollatzSequenceSolution : ISolvable
    {
        public void Solve()
        {
            int from = 13;
            int to = 1000000;
            int endOfSequence = 1;
            
            IDictionary<IDetection, IGenerator> pairs = new Dictionary<IDetection, IGenerator>()
            {
                { new EvenNumberDetection(), new HalferGenerator()},
                { new OddDetection(), new ThreeNPlusOneGenerator()}
            };

            this.Run(from, to, endOfSequence, pairs);
            
        }

        private void Run(int from, int to, int endOfSequence, IDictionary<IDetection, IGenerator> pairs)
        {
            int max = 0;
            long largestSequenceSeed = 0;

            for (long i = from; i < to; i++)
            {
                var sequencies = this.FindSequenciesOfNumberUntil(i, pairs, endOfSequence);

                // TODO replace with generic
                if (this.ReplaceMax(ref max, sequencies.Count))
                    largestSequenceSeed = i;

            }

            Console.WriteLine("the number producing the largest sequence is " + largestSequenceSeed);
        }

        private bool ReplaceMax(ref int max, int count)
        {
            if (max < count)
            {
                max = count;
                return true;
            }
            return false;
        }

        private List<long> FindSequenciesOfNumberUntil(long number, IDictionary<IDetection, IGenerator> pairs, int endOfSequence)
        {
            List<long> sequencies = new List<long>();

            while (true)
            {
                foreach (var pair in pairs)
                {
                    if (pair.Key.Check(number))
                    {
                        number = pair.Value.Next(number);
                        sequencies.Add(number);
                        break;
                    }
                }

                if (number == endOfSequence)
                    break;

            }

            return sequencies;
        }
        
    }
}
